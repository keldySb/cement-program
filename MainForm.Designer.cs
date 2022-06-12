
namespace indiv_zadanie
{
    partial class MainForm
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
            this.exit = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.Label();
            this.MainStore = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.PointBox = new System.Windows.Forms.ComboBox();
            this.PointLabel = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.ButtomBalance = new System.Windows.Forms.Button();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.RazmerBox = new System.Windows.Forms.ComboBox();
            this.QuantityBox = new System.Windows.Forms.ComboBox();
            this.CementBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonBuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainStore.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.DimGray;
            this.exit.Location = new System.Drawing.Point(1223, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 20);
            this.exit.TabIndex = 1;
            this.exit.Text = "x";
            this.exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Store
            // 
            this.Store.BackColor = System.Drawing.Color.White;
            this.Store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Store.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Store.Location = new System.Drawing.Point(0, 0);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(1238, 70);
            this.Store.TabIndex = 0;
            this.Store.Text = "Покупка цемента оптом";
            this.Store.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Store.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Store_MouseDown);
            this.Store.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Store_MouseMove);
            // 
            // MainStore
            // 
            this.MainStore.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainStore.Controls.Add(this.HelpButton);
            this.MainStore.Controls.Add(this.ButtonInfo);
            this.MainStore.Controls.Add(this.LabelInfo);
            this.MainStore.Controls.Add(this.PointBox);
            this.MainStore.Controls.Add(this.PointLabel);
            this.MainStore.Controls.Add(this.Balance);
            this.MainStore.Controls.Add(this.ButtomBalance);
            this.MainStore.Controls.Add(this.BalanceBox);
            this.MainStore.Controls.Add(this.BalanceLabel);
            this.MainStore.Controls.Add(this.RazmerBox);
            this.MainStore.Controls.Add(this.QuantityBox);
            this.MainStore.Controls.Add(this.CementBox);
            this.MainStore.Controls.Add(this.label2);
            this.MainStore.Controls.Add(this.label4);
            this.MainStore.Controls.Add(this.label3);
            this.MainStore.Controls.Add(this.ButtonBuy);
            this.MainStore.Controls.Add(this.panel2);
            this.MainStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainStore.Location = new System.Drawing.Point(0, 0);
            this.MainStore.Name = "MainStore";
            this.MainStore.Size = new System.Drawing.Size(1238, 592);
            this.MainStore.TabIndex = 2;
            this.MainStore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainStore_MouseDown);
            this.MainStore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainStore_MouseMove);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.Location = new System.Drawing.Point(52, 380);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(156, 26);
            this.HelpButton.TabIndex = 27;
            this.HelpButton.Text = "Как это работает?";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo.Location = new System.Drawing.Point(52, 284);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(156, 26);
            this.ButtonInfo.TabIndex = 24;
            this.ButtonInfo.Text = "Получение информации";
            this.ButtonInfo.UseVisualStyleBackColor = false;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LabelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelInfo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(630, 83);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(341, 283);
            this.LabelInfo.TabIndex = 23;
            this.LabelInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelInfo_MouseDown);
            this.LabelInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelInfo_MouseMove);
            // 
            // PointBox
            // 
            this.PointBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PointBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointBox.FormattingEnabled = true;
            this.PointBox.Items.AddRange(new object[] {
            "Чусовой",
            "Кунгур",
            "Березники",
            "Пермь",
            "Соликамск",
            "Краснокамск"});
            this.PointBox.Location = new System.Drawing.Point(391, 215);
            this.PointBox.Name = "PointBox";
            this.PointBox.Size = new System.Drawing.Size(233, 33);
            this.PointBox.TabIndex = 22;
            // 
            // PointLabel
            // 
            this.PointLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointLabel.Location = new System.Drawing.Point(387, 183);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(113, 20);
            this.PointLabel.TabIndex = 21;
            this.PointLabel.Text = "Место доставки";
            this.PointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Balance
            // 
            this.Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Balance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance.Location = new System.Drawing.Point(1081, 83);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(128, 20);
            this.Balance.TabIndex = 20;
            this.Balance.Text = "0";
            this.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtomBalance
            // 
            this.ButtomBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtomBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtomBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtomBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtomBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtomBalance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtomBalance.Location = new System.Drawing.Point(1007, 173);
            this.ButtomBalance.Name = "ButtomBalance";
            this.ButtomBalance.Size = new System.Drawing.Size(130, 26);
            this.ButtomBalance.TabIndex = 17;
            this.ButtomBalance.Text = "Пополнить баланс";
            this.ButtomBalance.UseVisualStyleBackColor = false;
            this.ButtomBalance.Click += new System.EventHandler(this.ButtomBalance_Click);
            // 
            // BalanceBox
            // 
            this.BalanceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceBox.Location = new System.Drawing.Point(992, 119);
            this.BalanceBox.MaxLength = 9;
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.Size = new System.Drawing.Size(170, 35);
            this.BalanceBox.TabIndex = 16;
            this.BalanceBox.Enter += new System.EventHandler(this.BalanceBox_Enter);
            this.BalanceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BalanceBox_KeyPress);
            this.BalanceBox.Leave += new System.EventHandler(this.BalanceBox_Leave);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceLabel.Location = new System.Drawing.Point(988, 83);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(100, 20);
            this.BalanceLabel.TabIndex = 15;
            this.BalanceLabel.Text = "Баланс(руб.): ";
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RazmerBox
            // 
            this.RazmerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RazmerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RazmerBox.FormattingEnabled = true;
            this.RazmerBox.Items.AddRange(new object[] {
            "25",
            "500",
            "1000"});
            this.RazmerBox.Location = new System.Drawing.Point(52, 215);
            this.RazmerBox.Name = "RazmerBox";
            this.RazmerBox.Size = new System.Drawing.Size(310, 33);
            this.RazmerBox.TabIndex = 14;
            // 
            // QuantityBox
            // 
            this.QuantityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityBox.FormattingEnabled = true;
            this.QuantityBox.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000"});
            this.QuantityBox.Location = new System.Drawing.Point(391, 117);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(233, 33);
            this.QuantityBox.TabIndex = 13;
            // 
            // CementBox
            // 
            this.CementBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CementBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CementBox.FormattingEnabled = true;
            this.CementBox.Items.AddRange(new object[] {
            "ЦЕМ I 42,5 Н СС (Цена - 8120 руб.)",
            "ЦЕМ II/А-Ш 42,5Н (Цена - 8550 руб.)",
            "ЦЕМ I 52,5Н (Цена - 10425 руб.)"});
            this.CementBox.Location = new System.Drawing.Point(52, 117);
            this.CementBox.Name = "CementBox";
            this.CementBox.Size = new System.Drawing.Size(310, 32);
            this.CementBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер мешков (кг)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(387, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество мешков";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Марка цемента";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonBuy
            // 
            this.ButtonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ButtonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuy.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBuy.Location = new System.Drawing.Point(52, 331);
            this.ButtonBuy.Name = "ButtonBuy";
            this.ButtonBuy.Size = new System.Drawing.Size(130, 26);
            this.ButtonBuy.TabIndex = 3;
            this.ButtonBuy.Text = "Купить";
            this.ButtonBuy.UseVisualStyleBackColor = false;
            this.ButtonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.Store);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 70);
            this.panel2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 592);
            this.Controls.Add(this.MainStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1238, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainStore.ResumeLayout(false);
            this.MainStore.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label Store;
        private System.Windows.Forms.Panel MainStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonBuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtomBalance;
        private System.Windows.Forms.TextBox BalanceBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.ComboBox RazmerBox;
        private System.Windows.Forms.ComboBox QuantityBox;
        private System.Windows.Forms.ComboBox CementBox;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.ComboBox PointBox;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button HelpButton;
    }
}