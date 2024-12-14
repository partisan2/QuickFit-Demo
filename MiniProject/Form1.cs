using System.Diagnostics;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        QuickFitAllocator allocator;
        int addr1, addr2, addr3, addr4;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetBlocks_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBlockSizes.Text);
            int[] blockSizes = textBlockSizes.Text.Split(',').Select(int.Parse).ToArray();
            allocator = new QuickFitAllocator(new List<int>(blockSizes));
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtPrc1.Text != "")
            {
                var process1 = allocator.Allocate(int.Parse(txtPrc1.Text.Trim()));
                addr1 = process1.address;
                string addressType = process1.isNew ? "New Address" : "Existing Address";
                dataGridAllocations.Rows.Add("Process 1", process1.blockSize, process1.address, addressType);
            }
            if (txtPrc2.Text != "")
            {
                var process2 = allocator.Allocate(int.Parse(txtPrc2.Text.Trim()));
                addr2 = process2.address;
                string addressType = process2.isNew ? "New Address" : "Existing Address";
                dataGridAllocations.Rows.Add("Process 2", process2.blockSize, process2.address, addressType);
            }
            if (txtPrc3.Text != "")
            {
                var process3 = allocator.Allocate(int.Parse(txtPrc3.Text.Trim()));
                addr3 = process3.address;
                string addressType = process3.isNew ? "New Address" : "Existing Address";
                dataGridAllocations.Rows.Add("Process 3", process3.blockSize, process3.address, addressType);
            }
            if (txtPrc4.Text != "")
            {
                var process4 = allocator.Allocate(int.Parse(txtPrc4.Text.Trim()));
                addr4 = process4.address;
                string addressType = process4.isNew ? "New Address" : "Existing Address";
                dataGridAllocations.Rows.Add("Process 4", process4.blockSize, process4.address, addressType);
            }
            dataGridAllocations.Visible = true;
            btnFree.Visible = true;
            btnFree2.Visible = true;
            btnFree3.Visible = true;
            btnFree4.Visible = true;
            button1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridAllocations.Columns.Add("Process", "Process");
            dataGridAllocations.Columns.Add("Size", "Size");
            dataGridAllocations.Columns.Add("Address", "Address");
            dataGridAllocations.Columns.Add("Type", "Type");

        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            allocator.Free(addr1);
            addr1 = -1;
        }

        private void btnFree2_Click(object sender, EventArgs e)
        {
            allocator.Free(addr2);
            addr2 = -1;
        }

        private void btnFree3_Click(object sender, EventArgs e)
        {
            allocator.Free(addr3);
            addr3 = -1; 
        }

        private void btnFree4_Click(object sender, EventArgs e)
        {
            allocator.Free(addr4);
            addr4 = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateFreeLists();
        }

        private void UpdateFreeLists()
        {
            listBoxFreeLists.Items.Clear();
            for (int i = 0; i < allocator.memoryPool.Count; i++)
            {
                var blockSize = allocator.memoryPool[i];
                string status = blockSize.HasValue ? "Allocated" : "Free";
                string sizeDisplay = blockSize.HasValue ? blockSize.Value.ToString() : "N/A";
                string line = $"Address {i}: Size {sizeDisplay}, Status: {status}";
                listBoxFreeLists.Items.Add(line);
            }
        }
    }
}
