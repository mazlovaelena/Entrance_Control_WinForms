namespace Control_Application_app
{
    partial class Form_Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Auth));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.but_auth = new System.Windows.Forms.Button();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(16, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.BackColor = System.Drawing.Color.Red;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error.ForeColor = System.Drawing.Color.Black;
            this.label_error.Location = new System.Drawing.Point(35, 295);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(364, 20);
            this.label_error.TabIndex = 3;
            this.label_error.Text = "Неверно указан логин и (или) пароль!";
            // 
            // but_auth
            // 
            this.but_auth.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_auth.ForeColor = System.Drawing.Color.Black;
            this.but_auth.Location = new System.Drawing.Point(120, 344);
            this.but_auth.Name = "but_auth";
            this.but_auth.Size = new System.Drawing.Size(157, 44);
            this.but_auth.TabIndex = 4;
            this.but_auth.Text = "Войти";
            this.but_auth.UseVisualStyleBackColor = false;
            this.but_auth.Click += new System.EventHandler(this.but_auth_Click);
            // 
            // TB_login
            // 
            this.TB_login.BackColor = System.Drawing.Color.AliceBlue;
            this.TB_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_login.ForeColor = System.Drawing.Color.SteelBlue;
            this.TB_login.Location = new System.Drawing.Point(120, 147);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(181, 24);
            this.TB_login.TabIndex = 5;
            // 
            // TB_password
            // 
            this.TB_password.BackColor = System.Drawing.Color.AliceBlue;
            this.TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_password.ForeColor = System.Drawing.Color.SteelBlue;
            this.TB_password.Location = new System.Drawing.Point(120, 201);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(181, 24);
            this.TB_password.TabIndex = 6;
            this.TB_password.UseSystemPasswordChar = true;
            // 
            // Form_Auth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Control_Application_app.Properties.Resources.Modern_Clean_Abstract_Shapes_Background_Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.but_auth);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button but_auth;
        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_password;
    }
}

