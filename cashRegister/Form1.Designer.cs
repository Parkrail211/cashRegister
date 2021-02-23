
namespace cashRegister
{
    partial class cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.item1 = new System.Windows.Forms.Label();
            this.burritoBox = new System.Windows.Forms.TextBox();
            this.tacoBox = new System.Windows.Forms.TextBox();
            this.item2 = new System.Windows.Forms.Label();
            this.nachoBox = new System.Windows.Forms.TextBox();
            this.item3 = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabelLeft = new System.Windows.Forms.Label();
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
            this.burritoPlus = new System.Windows.Forms.Button();
            this.burritoMinus = new System.Windows.Forms.Button();
            this.tacoMinus = new System.Windows.Forms.Button();
            this.tacoPlus = new System.Windows.Forms.Button();
            this.nachoMinus = new System.Windows.Forms.Button();
            this.nachoPlus = new System.Windows.Forms.Button();
            this.tenderedMinus = new System.Windows.Forms.Button();
            this.tenderedPlus = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // item1
            // 
            this.item1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item1.BackColor = System.Drawing.Color.White;
            this.item1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1.Location = new System.Drawing.Point(12, 39);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(114, 26);
            this.item1.TabIndex = 0;
            this.item1.Text = "Burritos   $5";
            // 
            // burritoBox
            // 
            this.burritoBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burritoBox.Location = new System.Drawing.Point(136, 45);
            this.burritoBox.Name = "burritoBox";
            this.burritoBox.Size = new System.Drawing.Size(32, 20);
            this.burritoBox.TabIndex = 1;
            this.burritoBox.Text = "0";
            // 
            // tacoBox
            // 
            this.tacoBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tacoBox.Location = new System.Drawing.Point(136, 87);
            this.tacoBox.Name = "tacoBox";
            this.tacoBox.Size = new System.Drawing.Size(32, 20);
            this.tacoBox.TabIndex = 3;
            this.tacoBox.Text = "0";
            // 
            // item2
            // 
            this.item2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item2.BackColor = System.Drawing.Color.White;
            this.item2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2.Location = new System.Drawing.Point(12, 82);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(114, 26);
            this.item2.TabIndex = 2;
            this.item2.Text = "Tacos $2.50";
            // 
            // nachoBox
            // 
            this.nachoBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nachoBox.Location = new System.Drawing.Point(136, 130);
            this.nachoBox.Name = "nachoBox";
            this.nachoBox.Size = new System.Drawing.Size(32, 20);
            this.nachoBox.TabIndex = 5;
            this.nachoBox.Text = "0";
            // 
            // item3
            // 
            this.item3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.item3.BackColor = System.Drawing.Color.White;
            this.item3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3.Location = new System.Drawing.Point(12, 123);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(114, 26);
            this.item3.TabIndex = 4;
            this.item3.Text = "Nachos   $3";
            // 
            // totalButton
            // 
            this.totalButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.totalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Location = new System.Drawing.Point(12, 171);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(193, 23);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Totals";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabelLeft
            // 
            this.subtotalLabelLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subtotalLabelLeft.BackColor = System.Drawing.Color.White;
            this.subtotalLabelLeft.Location = new System.Drawing.Point(26, 207);
            this.subtotalLabelLeft.Name = "subtotalLabelLeft";
            this.subtotalLabelLeft.Size = new System.Drawing.Size(87, 78);
            this.subtotalLabelLeft.TabIndex = 7;
            this.subtotalLabelLeft.Visible = false;
            // 
            // subtotalLabelRight
            // 
            this.subtotalLabelRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subtotalLabelRight.BackColor = System.Drawing.Color.White;
            this.subtotalLabelRight.Location = new System.Drawing.Point(109, 207);
            this.subtotalLabelRight.Name = "subtotalLabelRight";
            this.subtotalLabelRight.Size = new System.Drawing.Size(87, 78);
            this.subtotalLabelRight.TabIndex = 9;
            this.subtotalLabelRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.subtotalLabelRight.Visible = false;
            // 
            // tenderedBox
            // 
            this.tenderedBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tenderedBox.Location = new System.Drawing.Point(136, 316);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(32, 20);
            this.tenderedBox.TabIndex = 11;
            this.tenderedBox.Text = "0";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tenderedLabel.BackColor = System.Drawing.Color.White;
            this.tenderedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 310);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(114, 26);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(12, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(193, 23);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeBoxLeft
            // 
            this.changeBoxLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeBoxLeft.BackColor = System.Drawing.Color.White;
            this.changeBoxLeft.Location = new System.Drawing.Point(26, 395);
            this.changeBoxLeft.Name = "changeBoxLeft";
            this.changeBoxLeft.Size = new System.Drawing.Size(87, 29);
            this.changeBoxLeft.TabIndex = 13;
            this.changeBoxLeft.Visible = false;
            // 
            // changeBoxRight
            // 
            this.changeBoxRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.changeBoxRight.BackColor = System.Drawing.Color.White;
            this.changeBoxRight.Location = new System.Drawing.Point(109, 395);
            this.changeBoxRight.Name = "changeBoxRight";
            this.changeBoxRight.Size = new System.Drawing.Size(87, 29);
            this.changeBoxRight.TabIndex = 14;
            this.changeBoxRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.changeBoxRight.Visible = false;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptLabel.Location = new System.Drawing.Point(299, 39);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(178, 339);
            this.receiptLabel.TabIndex = 15;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.receiptLabel.Visible = false;
            // 
            // recieptButton
            // 
            this.recieptButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recieptButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.recieptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recieptButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.recieptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieptButton.Location = new System.Drawing.Point(12, 427);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(193, 23);
            this.recieptButton.TabIndex = 16;
            this.recieptButton.Text = "Print Receipt";
            this.recieptButton.UseVisualStyleBackColor = false;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // receiptLabelRight
            // 
            this.receiptLabelRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.receiptLabelRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptLabelRight.Location = new System.Drawing.Point(401, 39);
            this.receiptLabelRight.Name = "receiptLabelRight";
            this.receiptLabelRight.Size = new System.Drawing.Size(63, 338);
            this.receiptLabelRight.TabIndex = 17;
            this.receiptLabelRight.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.receiptLabelRight.Visible = false;
            // 
            // receiptSideLabel
            // 
            this.receiptSideLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.receiptSideLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptSideLabel.Location = new System.Drawing.Point(284, 39);
            this.receiptSideLabel.Name = "receiptSideLabel";
            this.receiptSideLabel.Size = new System.Drawing.Size(18, 338);
            this.receiptSideLabel.TabIndex = 18;
            this.receiptSideLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.receiptSideLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.newOrderButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(284, 427);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 23);
            this.newOrderButton.TabIndex = 19;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // burritoPlus
            // 
            this.burritoPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burritoPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burritoPlus.Location = new System.Drawing.Point(164, 45);
            this.burritoPlus.Name = "burritoPlus";
            this.burritoPlus.Size = new System.Drawing.Size(12, 20);
            this.burritoPlus.TabIndex = 20;
            this.burritoPlus.Text = "+";
            this.burritoPlus.UseVisualStyleBackColor = true;
            this.burritoPlus.Click += new System.EventHandler(this.burritoPlus_Click);
            // 
            // burritoMinus
            // 
            this.burritoMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.burritoMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burritoMinus.Location = new System.Drawing.Point(174, 45);
            this.burritoMinus.Name = "burritoMinus";
            this.burritoMinus.Size = new System.Drawing.Size(12, 20);
            this.burritoMinus.TabIndex = 21;
            this.burritoMinus.Text = "−";
            this.burritoMinus.UseVisualStyleBackColor = true;
            this.burritoMinus.Click += new System.EventHandler(this.burritoMinus_Click);
            // 
            // tacoMinus
            // 
            this.tacoMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tacoMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tacoMinus.Location = new System.Drawing.Point(174, 87);
            this.tacoMinus.Name = "tacoMinus";
            this.tacoMinus.Size = new System.Drawing.Size(12, 20);
            this.tacoMinus.TabIndex = 23;
            this.tacoMinus.Text = "−";
            this.tacoMinus.UseVisualStyleBackColor = true;
            this.tacoMinus.Click += new System.EventHandler(this.tacoMinus_Click);
            // 
            // tacoPlus
            // 
            this.tacoPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tacoPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tacoPlus.Location = new System.Drawing.Point(164, 87);
            this.tacoPlus.Name = "tacoPlus";
            this.tacoPlus.Size = new System.Drawing.Size(12, 20);
            this.tacoPlus.TabIndex = 22;
            this.tacoPlus.Text = "+";
            this.tacoPlus.UseVisualStyleBackColor = true;
            this.tacoPlus.Click += new System.EventHandler(this.tacoPlus_Click);
            // 
            // nachoMinus
            // 
            this.nachoMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nachoMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachoMinus.Location = new System.Drawing.Point(174, 130);
            this.nachoMinus.Name = "nachoMinus";
            this.nachoMinus.Size = new System.Drawing.Size(12, 20);
            this.nachoMinus.TabIndex = 25;
            this.nachoMinus.Text = "−";
            this.nachoMinus.UseVisualStyleBackColor = true;
            this.nachoMinus.Click += new System.EventHandler(this.nachoMinus_Click);
            // 
            // nachoPlus
            // 
            this.nachoPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nachoPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachoPlus.Location = new System.Drawing.Point(164, 130);
            this.nachoPlus.Name = "nachoPlus";
            this.nachoPlus.Size = new System.Drawing.Size(12, 20);
            this.nachoPlus.TabIndex = 24;
            this.nachoPlus.Text = "+";
            this.nachoPlus.UseVisualStyleBackColor = true;
            this.nachoPlus.Click += new System.EventHandler(this.nachoPlus_Click);
            // 
            // tenderedMinus
            // 
            this.tenderedMinus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tenderedMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedMinus.Location = new System.Drawing.Point(174, 316);
            this.tenderedMinus.Name = "tenderedMinus";
            this.tenderedMinus.Size = new System.Drawing.Size(12, 20);
            this.tenderedMinus.TabIndex = 27;
            this.tenderedMinus.Text = "−";
            this.tenderedMinus.UseVisualStyleBackColor = true;
            this.tenderedMinus.Click += new System.EventHandler(this.tenderedMinus_Click);
            // 
            // tenderedPlus
            // 
            this.tenderedPlus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tenderedPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedPlus.Location = new System.Drawing.Point(164, 316);
            this.tenderedPlus.Name = "tenderedPlus";
            this.tenderedPlus.Size = new System.Drawing.Size(12, 20);
            this.tenderedPlus.TabIndex = 26;
            this.tenderedPlus.Text = "+";
            this.tenderedPlus.UseVisualStyleBackColor = true;
            this.tenderedPlus.Click += new System.EventHandler(this.tenderedPlus_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.MistyRose;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(270, 9);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(216, 20);
            this.errorLabel.TabIndex = 28;
            this.errorLabel.Text = "Please input proper amounts.";
            this.errorLabel.Visible = false;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 462);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.tenderedMinus);
            this.Controls.Add(this.tenderedPlus);
            this.Controls.Add(this.nachoMinus);
            this.Controls.Add(this.nachoPlus);
            this.Controls.Add(this.tacoMinus);
            this.Controls.Add(this.tacoPlus);
            this.Controls.Add(this.burritoMinus);
            this.Controls.Add(this.burritoPlus);
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
            this.Controls.Add(this.subtotalLabelLeft);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.nachoBox);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.tacoBox);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.burritoBox);
            this.Controls.Add(this.item1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "Restaurante de Gran P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.TextBox burritoBox;
        private System.Windows.Forms.TextBox tacoBox;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.TextBox nachoBox;
        private System.Windows.Forms.Label item3;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabelLeft;
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
        private System.Windows.Forms.Button burritoPlus;
        private System.Windows.Forms.Button burritoMinus;
        private System.Windows.Forms.Button tacoMinus;
        private System.Windows.Forms.Button tacoPlus;
        private System.Windows.Forms.Button nachoMinus;
        private System.Windows.Forms.Button nachoPlus;
        private System.Windows.Forms.Button tenderedMinus;
        private System.Windows.Forms.Button tenderedPlus;
        private System.Windows.Forms.Label errorLabel;
    }
}

