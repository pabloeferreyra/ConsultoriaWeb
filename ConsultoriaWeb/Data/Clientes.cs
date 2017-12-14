using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultoriaWeb.Data
{
	public class Cliente
	{
		public int ID { get; set; }
		public int cuit { get; set; }
		public int registroAfip { get; set; }
		public string contacto { get; set; }
		public bool certPime { get; set; }
		public string claveFiscal { get; set; }
		public int idReferente { get; set; }
		public string razonSocial { get; set; }
		public string provincia { get; set; }
		public string ciudad { get; set; }
		public long telefono { get; set; }
		public long celular { get; set; }
		public string domicilio { get; set; }
		public string correo { get; set; }
	}
}
