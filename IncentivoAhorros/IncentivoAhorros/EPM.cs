using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncentivoAhorros
{
    class EPM
    {
        private List<Cliente> clientes;

        public EPM()
        {
            clientes = null;
            
        }

        public void almcenar_clientes(int cedula, int estrato, int meta_ahorro, int consumo_actual)
        {
            Cliente cliente = new Cliente(cedula, estrato, meta_ahorro, consumo_actual, null);
            clientes.Add(cliente);
        }

        public void Calcular_valor(int cedula)
        {
            int valor_parcial, valor_incentivo, valor_a_pagar;

            for (int i = 0; i<clientes.Count(); i++)
            {
                if (clientes[i].Cedula == cedula)
                {
                    Cliente cliente = clientes[i];
                    valor_parcial = cliente.Consumo_actual * 500;
                    valor_incentivo = (cliente.Meta_ahorro - valor_parcial) * 500;
                    valor_a_pagar = valor_parcial - valor_incentivo;

                    Factura factura = new Factura(cliente, valor_a_pagar);

                    cliente.Factura = factura;
                }
            }
        }

        public float Calcular_promedio()
        {
            int contador_consumo_actual = 0;
            float promedio_consumo_actual;

            for (int i = 0; i < clientes.Count(); i++)
            {
                contador_consumo_actual += clientes[i].Consumo_actual;
            }

            promedio_consumo_actual = contador_consumo_actual / clientes.Count();
            return promedio_consumo_actual;
        }

        public int Calcular_concepto_descuento()
        {
            int valor_total_descuentos = 0;

            for (int i = 0; i < clientes.Count(); i++)
            {
                Cliente cliente = clientes[i];
                if (cliente.Factura == null)
                {

                }
            }
        }

    }
}
