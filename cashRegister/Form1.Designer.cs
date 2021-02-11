
namespace cashRegister
{
    partial class Form1
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
            this.item1 = new System.Windows.Forms.Label();
            this.item1Box = new System.Windows.Forms.TextBox();
            this.item2Box = new System.Windows.Forms.TextBox();
            this.item2 = new System.Windows.Forms.Label();
            this.item3Box = new System.Windows.Forms.TextBox();
            this.item3 = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabelLeft = new System.Windows.Forms.Label();
            this.barLabel = new System.Windows.Forms.Label();
            this.subtotalLabelRight = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeBoxLeft = new System.Windows.Forms.Label();
            this.changeBoxRight = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.receiptLabelRight = new System.Windows.Forms.Label();
            this.receiptSideLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item1
            // 
            this.item1.AutoSize = true;
            this.item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1.Location = new System.Drawing.Point(53, 40);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(60, 24);
            this.item1.TabIndex = 0;
            this.item1.Text = "Item 1";
            // 
            // item1Box
            // 
            this.item1Box.Location = new System.Drawing.Point(136, 40);
            this.item1Box.Name = "item1Box";
            this.item1Box.Size = new System.Drawing.Size(32, 20);
            this.item1Box.TabIndex = 1;
            this.item1Box.Text = "0";
            // 
            // item2Box
            // 
            this.item2Box.Location = new System.Drawing.Point(136, 82);
            this.item2Box.Name = "item2Box";
            this.item2Box.Size = new System.Drawing.Size(32, 20);
            this.item2Box.TabIndex = 3;
            this.item2Box.Text = "0";
            // 
            // item2
            // 
            this.item2.AutoSize = true;
            this.item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2.Location = new System.Drawing.Point(53, 82);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(60, 24);
            this.item2.TabIndex = 2;
            this.item2.Text = "Item 2";
            // 
            // item3Box
            // 
            this.item3Box.Location = new System.Drawing.Point(136, 125);
            this.item3Box.Name = "item3Box";
            this.item3Box.Size = new System.Drawing.Size(32, 20);
            this.item3Box.TabIndex = 5;
            this.item3Box.Text = "0";
            // 
            // item3
            // 
            this.item3.AutoSize = true;
            this.item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3.Location = new System.Drawing.Point(53, 125);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(60, 24);
            this.item3.TabIndex = 4;
            this.item3.Text = "Item 3";
            // 
            // totalButton
            // 
            this.totalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Location = new System.Drawing.Point(12, 171);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(193, 23);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Totals";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabelLeft
            // 
            this.subtotalLabelLeft.Location = new System.Drawing.Point(26, 207);
            this.subtotalLabelLeft.Name = "subtotalLabelLeft";
            this.subtotalLabelLeft.Size = new System.Drawing.Size(87, 131);
            this.subtotalLabelLeft.TabIndex = 7;
            // 
            // barLabel
            // 
            this.barLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barLabel.Location = new System.Drawing.Point(9, 285);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(201, 10);
            this.barLabel.TabIndex = 8;
            this.barLabel.Visible = false;
            // 
            // subtotalLabelRight
            // 
            this.subtotalLabelRight.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabelRight.Location = new System.Drawing.Point(109, 207);
            this.subtotalLabelRight.Name = "subtotalLabelRight";
            this.subtotalLabelRight.Size = new System.Drawing.Size(87, 78);
            this.subtotalLabelRight.TabIndex = 9;
            this.subtotalLabelRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(136, 318);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(32, 20);
            this.tenderedBox.TabIndex = 11;
            this.tenderedBox.Text = "0";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(25, 314);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(94, 24);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(12, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(193, 23);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeBoxLeft
            // 
            this.changeBoxLeft.Location = new System.Drawing.Point(26, 395);
            this.changeBoxLeft.Name = "changeBoxLeft";
            this.changeBoxLeft.Size = new System.Drawing.Size(87, 131);
            this.changeBoxLeft.TabIndex = 13;
            // 
            // changeBoxRight
            // 
            this.changeBoxRight.Location = new System.Drawing.Point(109, 395);
            this.changeBoxRight.Name = "changeBoxRight";
            this.changeBoxRight.Size = new System.Drawing.Size(87, 131);
            this.changeBoxRight.TabIndex = 14;
            this.changeBoxRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptLabel.Location = new System.Drawing.Point(327, 40);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(153, 339);
            this.receiptLabel.TabIndex = 15;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.receiptLabel.Visible = false;
            // 
            // recieptButton
            // 
            this.recieptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recieptButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.recieptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieptButton.Location = new System.Drawing.Point(12, 427);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(193, 23);
            this.recieptButton.TabIndex = 16;
            this.recieptButton.Text = "Print Receipt";
            this.recieptButton.UseVisualStyleBackColor = true;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // receiptLabelRight
            // 
            this.receiptLabelRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptLabelRight.Location = new System.Drawing.Point(414, 40);
            this.receiptLabelRight.Name = "receiptLabelRight";
            this.receiptLabelRight.Size = new System.Drawing.Size(49, 338);
            this.receiptLabelRight.TabIndex = 17;
            this.receiptLabelRight.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.receiptLabelRight.Visible = false;
            this.receiptLabelRight.Click += new System.EventHandler(this.receiptLabelRight_Click);
            // 
            // receiptSideLabel
            // 
            this.receiptSideLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptSideLabel.Location = new System.Drawing.Point(281, 40);
            this.receiptSideLabel.Name = "receiptSideLabel";
            this.receiptSideLabel.Size = new System.Drawing.Size(49, 338);
            this.receiptSideLabel.TabIndex = 18;
            this.receiptSideLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.receiptSideLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(284, 427);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 23);
            this.newOrderButton.TabIndex = 19;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 462);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptSideLabel);
            this.Controls.Add(this.receiptLabelRight);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeBoxRight);
            this.Controls.Add(this.changeBoxLeft);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.subtotalLabelRight);
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.subtotalLabelLeft);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.item3Box);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2Box);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1Box);
            this.Controls.Add(this.item1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.TextBox item1Box;
        private System.Windows.Forms.TextBox item2Box;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.TextBox item3Box;
        private System.Windows.Forms.Label item3;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabelLeft;
        private System.Windows.Forms.Label barLabel;
        private System.Windows.Forms.Label subtotalLabelRight;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeBoxLeft;
        private System.Windows.Forms.Label changeBoxRight;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Label receiptLabelRight;
        private System.Windows.Forms.Label receiptSideLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

