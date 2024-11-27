using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            //Navigates the user to the advanced search filters page when they click the button: More search options
            Search searchForm = new Search();
            searchForm.Show(); // Displays the Search 
        }
    }
}
