﻿namespace IKZavrsni
{
    partial class NaplacivanjeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaplacivanjeForma));
            this.naplacivanjeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.racunButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prikaziButton = new System.Windows.Forms.Button();
            this.doDatumaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.odDatumaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // naplacivanjeListView
            // 
            this.naplacivanjeListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.naplacivanjeListView.AllowColumnReorder = true;
            this.naplacivanjeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.naplacivanjeListView.FullRowSelect = true;
            this.naplacivanjeListView.GridLines = true;
            this.naplacivanjeListView.Location = new System.Drawing.Point(12, 134);
            this.naplacivanjeListView.MultiSelect = false;
            this.naplacivanjeListView.Name = "naplacivanjeListView";
            this.naplacivanjeListView.Size = new System.Drawing.Size(303, 395);
            this.naplacivanjeListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.naplacivanjeListView.TabIndex = 7;
            this.naplacivanjeListView.UseCompatibleStateImageBehavior = false;
            this.naplacivanjeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nekretnina";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Iznos za naplatu";
            this.columnHeader2.Width = 96;
            // 
            // racunButton
            // 
            this.racunButton.Location = new System.Drawing.Point(240, 535);
            this.racunButton.Name = "racunButton";
            this.racunButton.Size = new System.Drawing.Size(75, 23);
            this.racunButton.TabIndex = 9;
            this.racunButton.Text = "Račun";
            this.racunButton.UseVisualStyleBackColor = true;
            this.racunButton.Click += new System.EventHandler(this.racunButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(327, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prikaziButton);
            this.groupBox1.Controls.Add(this.doDatumaDateTimePicker);
            this.groupBox1.Controls.Add(this.odDatumaDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period";
            // 
            // prikaziButton
            // 
            this.prikaziButton.Location = new System.Drawing.Point(211, 83);
            this.prikaziButton.Name = "prikaziButton";
            this.prikaziButton.Size = new System.Drawing.Size(75, 23);
            this.prikaziButton.TabIndex = 13;
            this.prikaziButton.Text = "Prikaži";
            this.prikaziButton.UseVisualStyleBackColor = true;
            this.prikaziButton.Click += new System.EventHandler(this.prikaziButton_Click);
            // 
            // doDatumaDateTimePicker
            // 
            this.doDatumaDateTimePicker.Location = new System.Drawing.Point(74, 51);
            this.doDatumaDateTimePicker.Name = "doDatumaDateTimePicker";
            this.doDatumaDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.doDatumaDateTimePicker.TabIndex = 11;
            this.doDatumaDateTimePicker.Value = new System.DateTime(2013, 9, 10, 20, 54, 31, 0);
            // 
            // odDatumaDateTimePicker
            // 
            this.odDatumaDateTimePicker.Location = new System.Drawing.Point(74, 24);
            this.odDatumaDateTimePicker.Name = "odDatumaDateTimePicker";
            this.odDatumaDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.odDatumaDateTimePicker.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Do datuma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Od datuma:";
            // 
            // NaplacivanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.racunButton);
            this.Controls.Add(this.naplacivanjeListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NaplacivanjeForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naplaćivanje";
            this.Load += new System.EventHandler(this.Naplacivanje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView naplacivanjeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button racunButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker doDatumaDateTimePicker;
        private System.Windows.Forms.DateTimePicker odDatumaDateTimePicker;
        private System.Windows.Forms.Button prikaziButton;

    }
}