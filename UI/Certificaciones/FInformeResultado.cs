using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;
using Negocio.MultiIdioma;
using Servicios.Seguridad;
using Entidades.Certificaciones;
using Negocio.Certificaciones;
using Negocio.DefMatrizControl;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Forms;
using iText.Pdfa;
using iText.IO;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Kernel;
using iText.Kernel.Colors;

namespace Presentacion.Certificaciones
{
    public partial class FInformeResultado : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;
        NCertificacion nCertificacion = new NCertificacion();

        public FInformeResultado()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void UpdGrilla()
        {
            try
            {
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = nCertificacion.GetResumenCertificaciones((new NMatrizControl()).GetMatrizControlActiva());
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Inicializar()
        {
            UpdGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string archivo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+@"\SCIInformeResultado.pdf";
                PdfWriter pdfWriter = new PdfWriter(archivo);
                PdfDocument pdf = new PdfDocument(pdfWriter);
                Document informe = new Document(pdf, PageSize.A4);
                informe.SetMargins(60,20,55,20);

                // fuentes
                PdfFont fTitulo = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD);
                PdfFont fSubTitulo = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLD);
                PdfFont fTexto = PdfFontFactory.CreateFont(StandardFonts.COURIER);

                // fecha
                var fecha = new Paragraph(DateTime.Now.ToString());
                fecha.SetTextAlignment(TextAlignment.RIGHT);
                fecha.SetFont(fTexto);
                fecha.SetFontColor(ColorConstants.BLACK);
                fecha.SetFontSize(10);
                informe.Add(fecha);

                // titulo
                var titulo = new Paragraph("Infome de Resultado");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFont(fTitulo);
                titulo.SetFontColor(ColorConstants.BLUE);
                titulo.SetFontSize(20);
                informe.Add(titulo);

                //grilla
                string[] columnas = { "Area de Negocio", "Control Interno", "Certificaciones", "Excepciones", "Incidentes" };
                float[] ancho = {4,4,2,2,2};
                Table grilla = new Table(UnitValue.CreatePercentArray(ancho));
                grilla.SetWidth(UnitValue.CreatePercentValue(100));

                // grilla encabezado
                foreach (var col in columnas)
                {
                    grilla.AddHeaderCell(new Cell().Add(new Paragraph(col).SetFont(fSubTitulo).SetBackgroundColor(ColorConstants.LIGHT_GRAY)));
                }

                // grilla datos
                Paragraph dato;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell col  in fila.Cells)
                    {
                        dato = new Paragraph(col.Value.ToString());
                        dato.SetFont(fTexto);
                        dato.SetFontSize(10);

                        if (col.ColumnIndex>1)
                        {
                            dato.SetTextAlignment(TextAlignment.RIGHT);
                        }
                        grilla.AddCell(new Cell().Add(dato));
                    }

                }

                informe.Add(grilla);
                informe.Close();

                //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                
                System.Diagnostics.Process.Start(archivo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Tag != null)
                    {
                        item.Text = diccionario[item.Tag.ToString()];
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FInformeResultado_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FInformeResultado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
