
namespace Right_click_Helper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.certain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.order = new System.Windows.Forms.TextBox();
            this.regedit = new System.Windows.Forms.TextBox();
            this.dispaly_name = new System.Windows.Forms.TextBox();
            this.icon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.current_path = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "路径：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cancel.Location = new System.Drawing.Point(487, 308);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 30);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // certain
            // 
            this.certain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.certain.Location = new System.Drawing.Point(334, 308);
            this.certain.Name = "certain";
            this.certain.Size = new System.Drawing.Size(112, 30);
            this.certain.TabIndex = 4;
            this.certain.Text = "确定";
            this.certain.UseVisualStyleBackColor = true;
            this.certain.Click += new System.EventHandler(this.Certain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.order);
            this.groupBox1.Controls.Add(this.regedit);
            this.groupBox1.Controls.Add(this.dispaly_name);
            this.groupBox1.Controls.Add(this.icon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.Location = new System.Drawing.Point(24, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高级设置";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(106, 164);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(445, 27);
            this.order.TabIndex = 10;
            this.order.TextChanged += new System.EventHandler(this.Order_TextChanged);
            // 
            // regedit
            // 
            this.regedit.Location = new System.Drawing.Point(106, 124);
            this.regedit.Name = "regedit";
            this.regedit.Size = new System.Drawing.Size(445, 27);
            this.regedit.TabIndex = 9;
            this.regedit.Text = "*\\shell\\";
            this.regedit.TextChanged += new System.EventHandler(this.Regedit_TextChanged);
            // 
            // dispaly_name
            // 
            this.dispaly_name.Location = new System.Drawing.Point(106, 79);
            this.dispaly_name.Name = "dispaly_name";
            this.dispaly_name.Size = new System.Drawing.Size(445, 27);
            this.dispaly_name.TabIndex = 8;
            this.dispaly_name.TextChanged += new System.EventHandler(this.Dispaly_name_TextChanged);
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(106, 37);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(445, 27);
            this.icon.TabIndex = 6;
            this.icon.TextChanged += new System.EventHandler(this.Icon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "右键名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "完整指令：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "注册表路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "icon路径：";
            // 
            // current_path
            // 
            this.current_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.current_path.Location = new System.Drawing.Point(80, 26);
            this.current_path.Name = "current_path";
            this.current_path.Size = new System.Drawing.Size(519, 27);
            this.current_path.TabIndex = 8;
            this.current_path.TextChanged += new System.EventHandler(this.Current_path_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.current_path);
            this.Controls.Add(this.certain);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "右键初始化";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button certain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox icon;
        private System.Windows.Forms.TextBox current_path;
        private System.Windows.Forms.TextBox dispaly_name;
        private System.Windows.Forms.TextBox regedit;
        private System.Windows.Forms.TextBox order;
    }
}

