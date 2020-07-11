namespace DelightFul_Cake
{
    partial class View_Orders
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgViewCakes = new System.Windows.Forms.DataGridView();
            this.dgviewCurrent = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Orders = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCurrent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(220, 503);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(193, 23);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "New Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgViewCakes
            // 
            this.dgViewCakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCakes.Location = new System.Drawing.Point(12, 42);
            this.dgViewCakes.Name = "dgViewCakes";
            this.dgViewCakes.Size = new System.Drawing.Size(527, 150);
            this.dgViewCakes.TabIndex = 1;
            this.dgViewCakes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewCakes_CellContentClick);
            // 
            // dgviewCurrent
            // 
            this.dgviewCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewCurrent.Location = new System.Drawing.Point(8, 42);
            this.dgviewCurrent.Name = "dgviewCurrent";
            this.dgviewCurrent.Size = new System.Drawing.Size(538, 150);
            this.dgviewCurrent.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgviewCurrent);
            this.groupBox1.Location = new System.Drawing.Point(39, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Month Orders";
            // 
            // Orders
            // 
            this.Orders.AutoSize = true;
            this.Orders.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.Location = new System.Drawing.Point(216, 23);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(216, 20);
            this.Orders.TabIndex = 4;
            this.Orders.Text = "DelightFul Cake Orders";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgViewCakes);
            this.groupBox2.Location = new System.Drawing.Point(39, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Orders";
            // 
            // View_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.btnOrder);
            this.Name = "View_Orders";
            this.Text = "View_Orders";
            this.Load += new System.EventHandler(this.View_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewCurrent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgViewCakes;
        private System.Windows.Forms.DataGridView dgviewCurrent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Orders;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}