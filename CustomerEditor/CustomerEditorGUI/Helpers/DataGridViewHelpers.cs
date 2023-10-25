using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEditorGUI.Helpers
{
    public static class DataGridViewHelpers
    {
        public static void DesignUCLDataGridView(this DataGridView dataGridView)
        {
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.White;
           
        }
    }
}
