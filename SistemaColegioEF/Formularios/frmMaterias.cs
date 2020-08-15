using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaColegioEF.Modelo;
using System.Data.Entity.Validation;
using SistemaColegioEF.Controls;

namespace SistemaColegioEF.Formularios
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
            suscribeEventos();
        }
        EscuelaDB db = new EscuelaDB();
        ucAbm abm = new ucAbm();
        int id = 0;
        bool edit;

        private void suscribeEventos()
        {
            abm.OnClickAgregar += habilitarTextBox;
            abm.OnClickAgregar += limpiar;
            abm.OnClickEditar += habilitarTextBox;
            abm.OnClickEliminar += eliminar;
            abm.OnClickEliminar += limpiar;
            abm.OnClickAceptar += confirmar;
            abm.OnClickCancelar += deshabilitarTextBox;
            abm.deshabilitarGrilla += deshabilitGrilla;
            abm.habilitarGrilla += habilitGrilla;
            abm.OnClickCancelar += limpiar;
            abm.habilitarCampos += habilitarTextBox;
            abm.deshabilitarCampos += deshabilitarTextBox;
            abm.deshabilitarEdit += deshabilitEdit;
            pnlAcciones.Controls.Add(abm);
        }

        public void confirmar(object sender, EventArgs e)
        {
            try
            {
                if (abm.Valid = validarCampos())
                {
                    if (edit)
                    {
                        editar();
                    }
                    else
                    {
                        agregar();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete los campos necesarios");
                    return;
                }
                cargarMaterias();
                limpiar(sender, e);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public void agregar()
        {
            Materia oMateria = new Materia();
            oMateria.nombre = tbNombreMateria.Text.ToString();
            oMateria.activo = 1;
            db.Materias.Add(oMateria);
            db.SaveChanges();
            MessageBox.Show("Se agregó el registro con éxito!");
        }

        public void editar()
        {
            var materia = (from a in db.Materias
                       where a.idMateria == id
                       select a).FirstOrDefault();

            materia.nombre = tbNombreMateria.Text;

            db.SaveChanges();
            MessageBox.Show("Se modificó el registro con éxito!");
        }

        public void eliminar(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DialogResult dgEliminar = MessageBox.Show(this, "¿Está seguro que desea eliminar este registro?", "¡Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dgEliminar == DialogResult.Yes)
                {
                    try
                    {
                        //Materia oMateria = (from a in db.Materias
                        //                      where a.idMateria == id
                        //                      select a).FirstOrDefault();
                        //db.Materias.Remove(oMateria);

                        var materia = (from a in db.Materias
                                       where a.idMateria == id
                                       select a).FirstOrDefault();
                        materia.activo = 0; //Persona inactiva (Baja lógica)
                        db.SaveChanges();
                        MessageBox.Show("Se eliminó el registro con éxito!");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                cargarMaterias();
                limpiar(sender, e);
            }
            else
                abm.Valid = false;
        }

        public void limpiar(object sender, EventArgs e)
        {
            id = 0;
            tbNombreMateria.Clear();
            tbNombreMateria.Enabled = true;
        }

        public void habilitarTextBox(object sender, EventArgs e)
        {
            tbNombreMateria.Enabled = true;
            tbNombreMateria.Focus();
        }

        public void deshabilitarTextBox(object sender, EventArgs e)
        {
            tbNombreMateria.Enabled = false;
        }

        public void habilitGrilla(object sender, EventArgs e)
        {
            dgvMaterias.Enabled = true;
        }

        public void deshabilitGrilla(object sender, EventArgs e)
        {
            dgvMaterias.Enabled = false;
        }

        public void cargarCampos(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Error!");
                return;
            }
            edit = true;
            abm.Valid = validarCampos();
        }

        public void habilitEdit()
        {
            edit = true;
        }

        public void deshabilitEdit()
        {
            edit = false;
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(tbNombreMateria.Text))
                return false;
            return true;
        }

        public void cargarMaterias()
        {
            var result = from m in db.Materias
                         where m.activo == 1
                         select new
                         {
                             m.idMateria,
                             m.nombre
                         };

                             dgvMaterias.DataSource = result.ToList();
            dgvMaterias.Columns["idMateria"].Visible = false;
        }


        private void frmMaterias_Load(object sender, EventArgs e)
        {
            cargarMaterias();
            tbNombreMateria.Clear();
            this.dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.Columns[0].Width = 1;
            dgvMaterias.Columns[1].HeaderText = "Nombre de Materia";
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvMaterias.Rows[dgvMaterias.CurrentRow.Index].Cells[0].Value.ToString());
            var mat = (from a in db.Materias
                           where a.idMateria == id
                           select a).FirstOrDefault();
            tbNombreMateria.Text = mat.nombre;
            dgvMaterias.Rows[dgvMaterias.CurrentRow.Index].Selected = true;
            cargarCampos(sender, e);
        }
    }
}