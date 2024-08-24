    using TallerEventos.Clases;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;


    namespace WinFormsApp1
    {
        public partial class controlTareas : Form
        {
            List<Tarea> tareas = new List<Tarea>();
            Dictionary<Tarea, FlowLayoutPanel> tareaContenedores = new Dictionary<Tarea, FlowLayoutPanel>();
            public controlTareas()
            {
                InitializeComponent();
                TextBoxTarea.KeyDown += TextBoxTarea_KeyDown;
                comboBoxEstado.Items.AddRange(new string[] { "Sin Empezar", "En Progreso", "Completada" });
                comboBoxEstado.SelectedIndex = 0;
            }

            private void TextBoxTarea_KeyDown(object? sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    agregarTarea();
                }
            }

            private void agregarTarea()
            {
                if (TextBoxTarea.Text.Trim() == "")
                {
                    MessageBox.Show("No ha ingresado el nombre de la Tarea");
                    return;
                }

                string estadoInicial = comboBoxEstado.SelectedItem.ToString();
                Tarea nuevaTarea = new Tarea(TextBoxTarea.Text, estadoInicial);
                tareas.Add(nuevaTarea);

                FlowLayoutPanel panel = GetPanelEstado(estadoInicial);
                FlowLayoutPanel contenedorTarea = CrearContenedorTarea(nuevaTarea, panel);

                tareaContenedores[nuevaTarea] = contenedorTarea;

                TextBoxTarea.Clear();
            }

            private FlowLayoutPanel CrearContenedorTarea(Tarea tarea, FlowLayoutPanel panel)
            {
                Label etiquetaTarea = new Label
                {
                    Text = tarea.Nombre,
                    AutoSize = true,
                    Tag = tarea
                };

                ComboBox comboBoxEstadoTarea = new ComboBox
                {
                    Items = { "Sin Empezar", "En Progreso", "Completada" },
                    SelectedItem = tarea.Estado,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                comboBoxEstadoTarea.SelectedIndexChanged += (s, e) =>
                {
                    string nuevoEstado = comboBoxEstadoTarea.SelectedItem.ToString();
                    CambiarEstadoTarea(tarea, nuevoEstado);
                };

                FlowLayoutPanel tareaPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight
                };

                etiquetaTarea.DoubleClick += (s, e) =>
                {
                    tareas.Remove(tarea);
                    panel.Controls.Remove(tareaPanel);
                    tareaContenedores.Remove(tarea);
                };

                tareaPanel.Controls.Add(etiquetaTarea);
                tareaPanel.Controls.Add(comboBoxEstadoTarea);

                panel.Controls.Add(tareaPanel);

                return tareaPanel;
            }

            private void CambiarEstadoTarea(Tarea tarea, string nuevoEstado)
            {
                FlowLayoutPanel contenedorTarea = tareaContenedores[tarea];
                FlowLayoutPanel panelAnterior = contenedorTarea.Parent as FlowLayoutPanel;

                if (panelAnterior != null) 
                {
                    panelAnterior.Controls.Remove(contenedorTarea);
                }
                tarea.Estado = nuevoEstado;

                FlowLayoutPanel nuevoPanel = GetPanelEstado(nuevoEstado);
                nuevoPanel.Controls.Add(contenedorTarea);
            }

            private FlowLayoutPanel GetPanelEstado(string estado) {
                return estado switch
                {
                    "Sin Empezar" => flowSinEmpezar,
                    "En Progreso" => flowEnProgreso,
                    "Completada" => flowCompletadas,
                    _ => flowSinEmpezar,
                };
            }
            private void textBoxTarea_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
