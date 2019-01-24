using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChartUpdateExample
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            pivotGridControl1.BestFit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            List<object> cachedData = new List<object>();
            IList data = pivotGridControl1;            
            PropertyDescriptorCollection props = ((ITypedList)pivotGridControl1).GetItemProperties(null);
            PropertyDescriptor pdValues = props["Values"],
                pdSeries = props["Series"], 
                pdArguments = props["Arguments"];
            for(int i = 0; i < data.Count; i++) {
                object series = pdSeries.GetValue(data[i]);
                object argument = pdArguments.GetValue(data[i]);
                object value = pdValues.GetValue(data[i]);
                cachedData.Add(new Record(value == DBNull.Value ? 0 : Convert.ToInt32(value), argument, series));
            }
            
            chartControl1.SeriesDataMember = "Series";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Argument";
            chartControl1.SeriesTemplate.ValueDataMembers.Clear();
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange( new string[] { "Value" });
            chartControl1.DataSource = cachedData;
        }
    }
}