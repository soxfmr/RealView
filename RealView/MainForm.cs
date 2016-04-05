using RealView.Core;
using RealView.Core.Model;
using RealView.Core.Parser;
using RealView.Core.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (ProviderInfo pi in App.Providers)
            {
                comboxProvider.Items.Add(pi.Alias);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edKeyword.Text))
            {
                MessageBox.Show(this, "输入关键词老司机带你飞", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                edKeyword.Focus();
                return;
            }

            string name = comboxProvider.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }

            Provider provider = ProviderFactory.CreateProvider(name, OnDataLoaded);

            if (provider != null)
            {
                provider.Load(edKeyword.Text, provider.getTag() as ParserContract);
            }
        }

        private void OnDataLoaded(object sender, DataLoadedEventArgs e)
        {
            ResourceSet resources = e.ResourceSet;
            if (resources == null)
            {
                return;
            }

            resourcesListbox.Items.Clear();
            foreach (ResourceInfo info in resources.ResourceList)
            {
                resourcesListbox.Items.Add(info.Title);
            }
        }
    }
}
