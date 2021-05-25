namespace Calculadora_Heuristicas
{
    partial class formCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculadora));
            this.textBoxPantalla = new System.Windows.Forms.TextBox();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnSignoIgual = new System.Windows.Forms.Button();
            this.btnSignoPunto = new System.Windows.Forms.Button();
            this.btnSignoSumar = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnSignoPor = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnSignoMenos = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnSignoDividir = new System.Windows.Forms.Button();
            this.btnBorrarUnNumero = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrarNumeros = new System.Windows.Forms.Button();
            this.textBoxPantallaSecundaria = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.btnSignoRaiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPantalla
            // 
            this.textBoxPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(196)))), ((int)(((byte)(162)))));
            this.textBoxPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPantalla.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPantalla.ForeColor = System.Drawing.Color.White;
            this.textBoxPantalla.Location = new System.Drawing.Point(6, 38);
            this.textBoxPantalla.MaxLength = 8;
            this.textBoxPantalla.Name = "textBoxPantalla";
            this.textBoxPantalla.ReadOnly = true;
            this.textBoxPantalla.Size = new System.Drawing.Size(275, 63);
            this.textBoxPantalla.TabIndex = 1;
            this.textBoxPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum0.Location = new System.Drawing.Point(75, 327);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(68, 53);
            this.btnNum0.TabIndex = 10;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnSignoIgual
            // 
            this.btnSignoIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(123)))), ((int)(((byte)(111)))));
            this.btnSignoIgual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(83)))));
            this.btnSignoIgual.FlatAppearance.BorderSize = 0;
            this.btnSignoIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(79)))), ((int)(((byte)(63)))));
            this.btnSignoIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoIgual.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoIgual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoIgual.Location = new System.Drawing.Point(213, 327);
            this.btnSignoIgual.Name = "btnSignoIgual";
            this.btnSignoIgual.Size = new System.Drawing.Size(68, 53);
            this.btnSignoIgual.TabIndex = 12;
            this.btnSignoIgual.Text = "=";
            this.btnSignoIgual.UseVisualStyleBackColor = false;
            this.btnSignoIgual.Click += new System.EventHandler(this.btnSignoIgual_Click);
            // 
            // btnSignoPunto
            // 
            this.btnSignoPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnSignoPunto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnSignoPunto.FlatAppearance.BorderSize = 0;
            this.btnSignoPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSignoPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoPunto.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoPunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoPunto.Location = new System.Drawing.Point(144, 327);
            this.btnSignoPunto.Name = "btnSignoPunto";
            this.btnSignoPunto.Size = new System.Drawing.Size(68, 53);
            this.btnSignoPunto.TabIndex = 11;
            this.btnSignoPunto.Text = ".";
            this.btnSignoPunto.UseVisualStyleBackColor = false;
            this.btnSignoPunto.Click += new System.EventHandler(this.btnSignoPunto_Click);
            // 
            // btnSignoSumar
            // 
            this.btnSignoSumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnSignoSumar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnSignoSumar.FlatAppearance.BorderSize = 0;
            this.btnSignoSumar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnSignoSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoSumar.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoSumar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoSumar.Location = new System.Drawing.Point(213, 272);
            this.btnSignoSumar.Name = "btnSignoSumar";
            this.btnSignoSumar.Size = new System.Drawing.Size(68, 53);
            this.btnSignoSumar.TabIndex = 16;
            this.btnSignoSumar.Text = "+";
            this.btnSignoSumar.UseVisualStyleBackColor = false;
            this.btnSignoSumar.Click += new System.EventHandler(this.btnSignoSumar_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum3.Location = new System.Drawing.Point(144, 272);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(68, 53);
            this.btnNum3.TabIndex = 15;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum2.Location = new System.Drawing.Point(75, 272);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(68, 53);
            this.btnNum2.TabIndex = 14;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum1.Location = new System.Drawing.Point(6, 272);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(68, 53);
            this.btnNum1.TabIndex = 13;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnSignoPor
            // 
            this.btnSignoPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnSignoPor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnSignoPor.FlatAppearance.BorderSize = 0;
            this.btnSignoPor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnSignoPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoPor.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoPor.Location = new System.Drawing.Point(213, 162);
            this.btnSignoPor.Name = "btnSignoPor";
            this.btnSignoPor.Size = new System.Drawing.Size(68, 53);
            this.btnSignoPor.TabIndex = 24;
            this.btnSignoPor.Text = "x";
            this.btnSignoPor.UseVisualStyleBackColor = false;
            this.btnSignoPor.Click += new System.EventHandler(this.btnSignoPor_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum9.Location = new System.Drawing.Point(144, 162);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(68, 53);
            this.btnNum9.TabIndex = 23;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum8.Location = new System.Drawing.Point(75, 162);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(68, 53);
            this.btnNum8.TabIndex = 22;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum7.Location = new System.Drawing.Point(6, 162);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(68, 53);
            this.btnNum7.TabIndex = 21;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnSignoMenos
            // 
            this.btnSignoMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnSignoMenos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnSignoMenos.FlatAppearance.BorderSize = 0;
            this.btnSignoMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnSignoMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoMenos.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoMenos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoMenos.Location = new System.Drawing.Point(213, 217);
            this.btnSignoMenos.Name = "btnSignoMenos";
            this.btnSignoMenos.Size = new System.Drawing.Size(68, 53);
            this.btnSignoMenos.TabIndex = 20;
            this.btnSignoMenos.Text = "-";
            this.btnSignoMenos.UseVisualStyleBackColor = false;
            this.btnSignoMenos.Click += new System.EventHandler(this.btnSignoMenos_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum6.Location = new System.Drawing.Point(144, 217);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(68, 53);
            this.btnNum6.TabIndex = 19;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum5.Location = new System.Drawing.Point(75, 217);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(68, 53);
            this.btnNum5.TabIndex = 18;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNum4.Location = new System.Drawing.Point(6, 217);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(68, 53);
            this.btnNum4.TabIndex = 17;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnSignoDividir
            // 
            this.btnSignoDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnSignoDividir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnSignoDividir.FlatAppearance.BorderSize = 0;
            this.btnSignoDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnSignoDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoDividir.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoDividir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoDividir.Location = new System.Drawing.Point(213, 107);
            this.btnSignoDividir.Name = "btnSignoDividir";
            this.btnSignoDividir.Size = new System.Drawing.Size(68, 53);
            this.btnSignoDividir.TabIndex = 28;
            this.btnSignoDividir.Text = "÷";
            this.btnSignoDividir.UseVisualStyleBackColor = false;
            this.btnSignoDividir.Click += new System.EventHandler(this.btnSignoDividir_Click);
            // 
            // btnBorrarUnNumero
            // 
            this.btnBorrarUnNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnBorrarUnNumero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnBorrarUnNumero.FlatAppearance.BorderSize = 0;
            this.btnBorrarUnNumero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnBorrarUnNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarUnNumero.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUnNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarUnNumero.Location = new System.Drawing.Point(144, 107);
            this.btnBorrarUnNumero.Name = "btnBorrarUnNumero";
            this.btnBorrarUnNumero.Size = new System.Drawing.Size(68, 53);
            this.btnBorrarUnNumero.TabIndex = 27;
            this.btnBorrarUnNumero.Text = "←";
            this.btnBorrarUnNumero.UseVisualStyleBackColor = false;
            this.btnBorrarUnNumero.Click += new System.EventHandler(this.btnBorrarUnNumero_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnBorrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnBorrarTodo.FlatAppearance.BorderSize = 0;
            this.btnBorrarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarTodo.Location = new System.Drawing.Point(75, 107);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(68, 53);
            this.btnBorrarTodo.TabIndex = 26;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrarNumeros
            // 
            this.btnBorrarNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnBorrarNumeros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnBorrarNumeros.FlatAppearance.BorderSize = 0;
            this.btnBorrarNumeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnBorrarNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarNumeros.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrarNumeros.Location = new System.Drawing.Point(6, 107);
            this.btnBorrarNumeros.Name = "btnBorrarNumeros";
            this.btnBorrarNumeros.Size = new System.Drawing.Size(68, 53);
            this.btnBorrarNumeros.TabIndex = 25;
            this.btnBorrarNumeros.Text = "CE";
            this.btnBorrarNumeros.UseVisualStyleBackColor = false;
            this.btnBorrarNumeros.Click += new System.EventHandler(this.btnBorrarNumeros_Click);
            // 
            // textBoxPantallaSecundaria
            // 
            this.textBoxPantallaSecundaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(166)))), ((int)(((byte)(155)))));
            this.textBoxPantallaSecundaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPantallaSecundaria.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPantallaSecundaria.ForeColor = System.Drawing.Color.White;
            this.textBoxPantallaSecundaria.Location = new System.Drawing.Point(6, 15);
            this.textBoxPantallaSecundaria.MaxLength = 25;
            this.textBoxPantallaSecundaria.Name = "textBoxPantallaSecundaria";
            this.textBoxPantallaSecundaria.ReadOnly = true;
            this.textBoxPantallaSecundaria.Size = new System.Drawing.Size(275, 25);
            this.textBoxPantallaSecundaria.TabIndex = 29;
            this.textBoxPantallaSecundaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(14, 387);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 30;
            // 
            // btnSignoRaiz
            // 
            this.btnSignoRaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(96)))));
            this.btnSignoRaiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(70)))));
            this.btnSignoRaiz.FlatAppearance.BorderSize = 0;
            this.btnSignoRaiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(49)))));
            this.btnSignoRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignoRaiz.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignoRaiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSignoRaiz.Location = new System.Drawing.Point(6, 327);
            this.btnSignoRaiz.Name = "btnSignoRaiz";
            this.btnSignoRaiz.Size = new System.Drawing.Size(68, 53);
            this.btnSignoRaiz.TabIndex = 31;
            this.btnSignoRaiz.Text = "√";
            this.btnSignoRaiz.UseVisualStyleBackColor = false;
            this.btnSignoRaiz.Click += new System.EventHandler(this.btnSignoRaiz_Click_1);
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(286, 406);
            this.Controls.Add(this.btnSignoRaiz);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxPantallaSecundaria);
            this.Controls.Add(this.btnSignoDividir);
            this.Controls.Add(this.btnBorrarUnNumero);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrarNumeros);
            this.Controls.Add(this.btnSignoPor);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnSignoMenos);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnSignoSumar);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnSignoIgual);
            this.Controls.Add(this.btnSignoPunto);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.textBoxPantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formCalculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPantalla;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnSignoIgual;
        private System.Windows.Forms.Button btnSignoPunto;
        private System.Windows.Forms.Button btnSignoSumar;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnSignoPor;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnSignoMenos;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnSignoDividir;
        private System.Windows.Forms.Button btnBorrarUnNumero;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrarNumeros;
        private System.Windows.Forms.TextBox textBoxPantallaSecundaria;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnSignoRaiz;
    }
}

