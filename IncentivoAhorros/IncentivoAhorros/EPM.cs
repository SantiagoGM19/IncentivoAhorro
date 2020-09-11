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
            Cliente cliente = new Cliente(cedula, estrato, meta_ahorro, consumo_actual);
            clientes.Add(cliente);
        }

        public float Calcular_valor(int cedula)
        {
            int valor_parcial, valor_incentivo, valor_a_pagar;
            valor_a_pagar = 0;

            for (int i = 0; i<clientes.Count(); i++)
            {
                if (clientes[i].Cedula == cedula)
                {
                    Cliente cliente = clientes[i];
                    valor_parcial = cliente.Consumo_actual * 500;
                    valor_incentivo = (cliente.Meta_ahorro - valor_parcial) * 500;
                    valor_a_pagar = valor_parcial - valor_incentivo;
                }
            }

            return valor_a_pagar;
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

        public float Calcular_concepto_descuento()
        {
            float valor_total_descuentos = 0;

            for (int i = 0; i < clientes.Count(); i++)
            {
                Cliente cliente = clientes[i];

                if (cliente.Consumo_actual < cliente.Meta_ahorro)
                {
                    valor_total_descuentos += (cliente.Meta_ahorro - cliente.Consumo_actual);
                }
            }

            return valor_total_descuentos;

        }


        public float Calcular_porcentaje_ahorros()
        {
            int cont_estrato1, cont_estrato2, cont_estrato3, cont_estrato4, cont_estrato5, cont_estrato6, contador_total, 
                kilovatios, ahorro_dinero;

            float porcentaje_ahorro_kw, porcentaje_ahorro_dinero;

            cont_estrato1 = cont_estrato2 = cont_estrato3 = cont_estrato4 = cont_estrato5 = cont_estrato6 = 
                contador_total = kilovatios = ahorro_dinero = 0;

            for (int i = 0; i < clientes.Count(); i++)
            {
                Cliente cliente = clientes[i];

                switch (cliente.Estrato)
                {
                    case 1:

                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                }
            }
        }

        private void comparar(Cliente cliente)
        {
           
        }

    }
}
