

using System.Drawing;
using System.Security.Policy;

namespace MiniProject
{
    internal class QuickFitAllocator
    {
        public  Dictionary<int, List<int>> freeLists;
        public  List<int?> memoryPool;

        public QuickFitAllocator(List<int> blockSizes)
        {
            freeLists = new Dictionary<int, List<int>>();
            memoryPool = new List<int?>();
            foreach (var size in blockSizes)
            {
                freeLists[size] = new List<int>();
                int address = memoryPool.Count;
                memoryPool.Add(null);
                freeLists[size].Add(address);
            }
        }

        public (int blockSize, int address, bool isNew) Allocate(int size)
        {
            foreach (var blockSize in new SortedSet<int>(freeLists.Keys))
            {
                if (blockSize == size && freeLists[blockSize].Count > 0)
                {
                    int address = freeLists[blockSize][0];
                    freeLists[blockSize].RemoveAt(0);
                    memoryPool[address] = size;
                    return (size,address,false);
                }
            }

            int newAddress = memoryPool.Count;
            memoryPool.Add(size);
            return (size,newAddress,true);
        }

        public (int size, int address) Free(int address)
        {
            if (address >= 0 && address < memoryPool.Count && memoryPool[address] != null)
            {
                int size = memoryPool[address].Value;
                memoryPool[address] = null; 

               
                if (freeLists.TryGetValue(size, out var freeList))
                {
                    freeList.Add(address);
                    MessageBox.Show($"Freed block of size {size} at address {address}.",
                                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return (size, address);
                }

                
                MessageBox.Show($"Freed block of size {size} at address {address}, but no suitable quick fit free list.",
                                "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (size, address);
            }
            else
            {
                MessageBox.Show($"Invalid address {address} for free operation.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (-1, address); 
            }
        }


        public bool IsBlockFree(int address)
        {
            if (address >= 0 && address < memoryPool.Count)
            {
                return memoryPool[address] == null;
            }
            return false;
        }
    }
}
