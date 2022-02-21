namespace MontanoP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string item = "TBD";
            if (rbMug.Checked) item = rbMug.Text;

            else if (rbPen.Checked) item = rbPen.Text;

            else if (rbUSB.Checked) item = rbUSB.Text;

            if(txbNumColors.Enabled == false)
            {
                txbNumColors.Text = "0";
            }



            //LogoOrderItem order = new LogoOrderItem(txbUserText.Text, cbxHasLogo.Checked, txbOrderNum.Text, item, int.Parse(txbNumColors.Text),int.Parse(txbNumberOfItems.Text));
            LogoOrderItem order = new LogoOrderItem(txbUserText.Text,cbxHasLogo.Checked);
            //LogoOrderItem order = new LogoOrderItem();
            

            order.NumItems = int.Parse(txbNumberOfItems.Text);
            order.OrderId = txbOrderNum.Text;
            order.HasLogo = cbxHasLogo.Checked;
            order.ItemType = item;
            order.NumColors = int.Parse(txbNumColors.Text);
            order.UserText = txbUserText.Text;
            
            
           
           
          
            txbResults.Text = order.ToString();

        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.Blue;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.Red;
        }
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Blue;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
        }

        private void cbxHasLogo_CheckedChanged(object sender, EventArgs e)
        {
            txbNumColors.Enabled = cbxHasLogo.Checked;
            
        }
    }
}