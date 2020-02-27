namespace WindowsFormsApplication1
{
    partial class frmDataTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sptcMain = new System.Windows.Forms.SplitContainer();
            this.txtDataEvent = new System.Windows.Forms.TextBox();
            this.grdTestList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sptcMain)).BeginInit();
            this.sptcMain.Panel1.SuspendLayout();
            this.sptcMain.Panel2.SuspendLayout();
            this.sptcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTestList)).BeginInit();
            this.SuspendLayout();
            // 
            // sptcMain
            // 
            this.sptcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptcMain.Location = new System.Drawing.Point(0, 0);
            this.sptcMain.Name = "sptcMain";
            this.sptcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptcMain.Panel1
            // 
            this.sptcMain.Panel1.Controls.Add(this.txtDataEvent);
            // 
            // sptcMain.Panel2
            // 
            this.sptcMain.Panel2.Controls.Add(this.grdTestList);
            this.sptcMain.Size = new System.Drawing.Size(1023, 554);
            this.sptcMain.SplitterDistance = 46;
            this.sptcMain.TabIndex = 0;
            // 
            // txtDataEvent
            // 
            this.txtDataEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataEvent.Location = new System.Drawing.Point(44, 12);
            this.txtDataEvent.Name = "txtDataEvent";
            this.txtDataEvent.Size = new System.Drawing.Size(945, 20);
            this.txtDataEvent.TabIndex = 0;
            this.txtDataEvent.TextChanged += new System.EventHandler(this.txtDataEvent_TextChanged);
            // 
            // grdTestList
            // 
            this.grdTestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTestList.Location = new System.Drawing.Point(0, 0);
            this.grdTestList.Name = "grdTestList";
            this.grdTestList.Size = new System.Drawing.Size(1023, 504);
            this.grdTestList.TabIndex = 0;
            this.grdTestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTestList_CellContentClick);
            // 
            // frmDataTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 554);
            this.Controls.Add(this.sptcMain);
            this.Name = "frmDataTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDataTest_Load);
            this.sptcMain.Panel1.ResumeLayout(false);
            this.sptcMain.Panel1.PerformLayout();
            this.sptcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptcMain)).EndInit();
            this.sptcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sptcMain;
        private System.Windows.Forms.TextBox txtDataEvent;
        private System.Windows.Forms.DataGridView grdTestList;
    }
}

