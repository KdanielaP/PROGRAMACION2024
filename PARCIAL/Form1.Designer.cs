using System.Collections.Generic;
using System;

namespace PARCIAL
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
    }

        #endregion
        namespace AgendaApp
    {
        class Tarea
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public bool Completada { get; set; }
            public string Responsable { get; set; }
        }

        class Program
        {
            static List<Tarea> tareas = new List<Tarea>();

            static void Main(string[] args)
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine("======= Agenda App =======");
                    Console.WriteLine("1. Crear tarea");
                    Console.WriteLine("2. Ver tareas");
                    Console.WriteLine("3. Marcar tarea como completada");
                    Console.WriteLine("4. Cambiar responsable de tarea");
                    Console.WriteLine("5. Salir");

                    Console.Write("Ingrese una opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            CrearTarea();
                            break;
                        case "2":
                            VerTareas();
                            break;
                        case "3":
                            MarcarTareaCompletada();
                            break;
                        case "4":
                            CambiarResponsable();
                            break;
                        case "5":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }
            }

            static void CrearTarea()
            {
                Console.Write("Nombre de la tarea: ");
                string nombre = Console.ReadLine();
                Console.Write("Descripción de la tarea: ");
                string descripcion = Console.ReadLine();
                Console.Write("Fecha de la tarea (dd/mm/yyyy): ");
                DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Tarea newTarea = new Tarea
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Fecha = fecha,
                    Completada = false,
                    Responsable = ""
                };

                tareas.Add(newTarea);
                Console.WriteLine("Tarea creada exitosamente.");
            }

            static void VerTareas()
            {
                Console.WriteLine("======= Lista de Tareas =======");
                foreach (var tarea in tareas)
                {
                    Console.WriteLine($"Nombre: {tarea.Nombre}");
                    Console.WriteLine($"Descripción: {tarea.Descripcion}");
                    Console.WriteLine($"Fecha: {tarea.Fecha.ToShortDateString()}");
                    Console.WriteLine($"Completada: {(tarea.Completada ? "Sí" : "No")}");
                    Console.WriteLine($"Responsable: {tarea.Responsable}");
                    Console.WriteLine("===============================");
                }
            }

            static void MarcarTareaCompletada()
            {
                Console.Write("Ingrese el nombre de la tarea que desea marcar como completada: ");
                string nombreTarea = Console.ReadLine();

                var tarea = tareas.Find(t => t.Nombre.ToLower() == nombreTarea.ToLower());
                if (tarea != null)
                {
                    tarea.Completada = true;
                    Console.WriteLine("La tarea fue marcada como completada.");
                }
                else
                {
                    Console.WriteLine("Tarea no encontrada.");
                }
            }

            static void CambiarResponsable()
            {
                Console.Write("Ingrese el nombre de la tarea a la que desea cambiar el responsable: ");
                string nombreTarea = Console.ReadLine();

                var tarea = tareas.Find(t => t.Nombre.ToLower() == nombreTarea.ToLower());
                if (tarea != null)
                {
                    Console.Write("Nuevo responsable: ");
                    tarea.Responsable = Console.ReadLine();
                    Console.WriteLine("El responsable de la tarea ha sido actualizado.");
                }
                else
                {
                    Console.WriteLine("Tarea no encontrada.");
                }
            }
        }
    }
}

