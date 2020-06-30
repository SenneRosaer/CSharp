using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Main : Form
    {
        List<int> items = new List<int>();
        List<int> merge_items = new List<int>();
        
        public Main()
        {
            InitializeComponent();
            bubble_list.DataSource = items;
            merge_list.DataSource = merge_items;
        }

        private void bubble_add_Click(object sender, EventArgs e)
        {
            string input = bubble_input.Text;
            int value;
            Console.WriteLine(input);
            if (Int32.TryParse(input, out value))
            {
                items.Add(value);
                bubble_list.DataSource = null;
                bubble_list.DataSource = items;
                
            }
            bubble_input.Text = "";
        }

        private async void bubble_sort_Click(object sender, EventArgs e)
        {
            

             for (int i = 0; i < items.Count; i++)
            {
                for (int j = 0; j < items.Count - i -1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                     
                        int tmp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = tmp;

                        bubble_list.DataSource = null;
                        bubble_list.DataSource = items;

                        await Task.Delay(1000);
                        

                    }
                }
            }

            

        }

        private void merge_add_Click(object sender, EventArgs e)
        {
            string input = merge_input.Text;
            int value;
            Console.WriteLine(input);
            if (Int32.TryParse(input, out value))
            {
                merge_items.Add(value);
                merge_list.DataSource = null;
                merge_list.DataSource = merge_items;

            }
            merge_input.Text = "";
        }

        private void merge_sort_Click(object sender, EventArgs e)
        {
            merge_items = merge_sort_algo(merge_items);
            merge_list.DataSource = null;
            merge_list.DataSource = merge_items;

        }

        private List<int> merge_sort_algo(List<int> array)
        {
            if (array.Count > 1)
            {
                int middleArray = array.Count / 2;
                List<int> left = new List<int>();
                left = array.GetRange(0, middleArray);
                List<int> right = new List<int>();
                right = array.GetRange(middleArray, (array.Count - middleArray));

                left = merge_sort_algo(left);
                right = merge_sort_algo(right);

                int i = 0;
                int j = 0;
                int x = 0;

                List<int> L_copy = new List<int>(left);
                List<int> R_copy = new List<int>(right);

                List<int> tmp = new List<int>();
                while (L_copy.Count > 0 || R_copy.Count > 0)
                {
                    if (L_copy.Count == 0 && R_copy.Count != 0)
                    {
                        tmp.Add(R_copy[0]);
                        R_copy.RemoveAt(0);
                    }
                    else if (L_copy.Count != 0 && R_copy.Count == 0)
                    {
                        tmp.Add(L_copy[0]);
                        L_copy.RemoveAt(0);
                    }
                    else if ( L_copy[0] > R_copy[0])
                    {
                        tmp.Add(R_copy[0]);
                        R_copy.RemoveAt(0);
                    } 
                    else if ( L_copy[0] >= R_copy[0])
                    {
                        tmp.Add(L_copy[0]);
                        L_copy.RemoveAt(0);
                    }
                }

                array = tmp;
            }

            return array;

        }

        private void bubble_clear_Click(object sender, EventArgs e)
        {
            items.Clear();
            bubble_list.DataSource = null;
            bubble_list.DataSource = items;
        }

        private void merge_clear_Click(object sender, EventArgs e)
        {
            merge_items.Clear();
            merge_list.DataSource = null;
            merge_list.DataSource = merge_items;
        }
    }
}
