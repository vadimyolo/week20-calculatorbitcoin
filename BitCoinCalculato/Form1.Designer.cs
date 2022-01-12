using System;

namespace BitCoinCalculato
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRates = new System.Windows.Forms.Button();
            this.amountOfBtc = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyMenu.Location = new System.Drawing.Point(58, 38);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(121, 23);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select currency";
            
            // 
            // getRates
            // 
            this.getRates.Location = new System.Drawing.Point(200, 111);
            this.getRates.Name = "getRates";
            this.getRates.Size = new System.Drawing.Size(75, 23);
            this.getRates.TabIndex = 1;
            this.getRates.Text = "Get Rates";
            this.getRates.UseVisualStyleBackColor = true;
            this.getRates.Click += new System.EventHandler(this.getRates_Click);
            // 
            // amountOfBtc
            // 
            this.amountOfBtc.Location = new System.Drawing.Point(58, 111);
            this.amountOfBtc.Name = "amountOfBtc";
            this.amountOfBtc.PlaceholderText = "Amount of BitCoins";
            this.amountOfBtc.Size = new System.Drawing.Size(121, 23);
            this.amountOfBtc.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(58, 200);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 23);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(58, 171);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(39, 15);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text = "Result";
            this.resultLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBtc);
            this.Controls.Add(this.getRates);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "Bitcoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRates;
        private System.Windows.Forms.TextBox amountOfBtc;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLbl;

        public EventHandler currencyMenu_SelectedIndexChanged { get; private set; }
    }
}

