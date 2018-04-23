using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void gridView1_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet1.Categories);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            List<object> cachedData = new List<object>();
            IList data = pivotGridControl1;            
            PropertyDescriptorCollection props = ((ITypedList)pivotGridControl1).GetItemProperties(null);
            PropertyDescriptor pdValues = props["Values"],
                pdSeries = props["Series"], 
                pdArguments = props["Arguments"];
            for(int i = 0; i < data.Count; i++) {
                object serie = pdSeries.GetValue(data[i]);
                object argument = pdArguments.GetValue(data[i]);
                object value = pdValues.GetValue(data[i]);
                cachedData.Add(new Record(value == DBNull.Value ? 0 : Convert.ToInt32(value), argument, serie));
            }
            
            chartControl1.SeriesDataMember = "Series";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            chartControl1.SeriesTemplate.ValueDataMembers.Clear();
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange( new string[] { "Values" });
            chartControl1.DataSource = cachedData;
        }

        private void chartControl1_BoundDataChanged(object sender, EventArgs e) {

        }
    }

    public class Record {
        int value;

        public int Values {
            get { return this.value; }
            set { this.value = value; }
        }
        object argument;

        public object Arguments {
            get { return argument; }
            set { argument = value; }
        }

        object series;
        public object Series {
            get { return series; }
            set { series = value; }        
        }


        public Record(int value, object argument, object series) {
            this.value = value;
            this.argument = argument;
            this.series = series;
        
        }
    
    }
}