namespace WinFormsApp1
{
    partial class controlTareas
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
            TextBoxTarea = new TextBox();
            comboBoxEstado = new ComboBox();
            flowSinEmpezar = new FlowLayoutPanel();
            flowCompletadas = new FlowLayoutPanel();
            flowEnProgreso = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // TextBoxTarea
            // 
            TextBoxTarea.Location = new Point(259, 40);
            TextBoxTarea.Name = "TextBoxTarea";
            TextBoxTarea.Size = new Size(427, 27);
            TextBoxTarea.TabIndex = 0;
            TextBoxTarea.Text = "Ingrese su Tarea";
            TextBoxTarea.TextChanged += textBoxTarea_TextChanged;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(82, 39);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(171, 28);
            comboBoxEstado.TabIndex = 1;
            // 
            // flowSinEmpezar
            // 
            flowSinEmpezar.BorderStyle = BorderStyle.Fixed3D;
            flowSinEmpezar.Location = new Point(88, 136);
            flowSinEmpezar.Name = "flowSinEmpezar";
            flowSinEmpezar.Size = new Size(176, 253);
            flowSinEmpezar.TabIndex = 2;
            // 
            // flowCompletadas
            // 
            flowCompletadas.BorderStyle = BorderStyle.Fixed3D;
            flowCompletadas.Location = new Point(482, 136);
            flowCompletadas.Name = "flowCompletadas";
            flowCompletadas.Size = new Size(176, 253);
            flowCompletadas.TabIndex = 3;
            // 
            // flowEnProgreso
            // 
            flowEnProgreso.BorderStyle = BorderStyle.Fixed3D;
            flowEnProgreso.Location = new Point(285, 136);
            flowEnProgreso.Name = "flowEnProgreso";
            flowEnProgreso.Size = new Size(176, 253);
            flowEnProgreso.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 108);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Sin Empezar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "En Progreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 108);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 6;
            label3.Text = "Completadas";
            // 
            // controlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowCompletadas);
            Controls.Add(flowEnProgreso);
            Controls.Add(flowSinEmpezar);
            Controls.Add(comboBoxEstado);
            Controls.Add(TextBoxTarea);
            Name = "controlTareas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxTarea;
        private ComboBox comboBoxEstado;
        private FlowLayoutPanel flowSinEmpezar;
        private FlowLayoutPanel flowCompletadas;
        private FlowLayoutPanel flowEnProgreso;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
