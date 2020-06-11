using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFE
{
    class ClassRecibo
    {
        //Atributos de clase
        public double kw,pago;
        public string contrato;
        //Métodos de la clase
        public void Recibo()
        {
            switch(contrato)
            {
                case "Hogar":
                    if(kw>=0 && kw<=250)
                    {
                        pago = kw * 0.65;
                    }
                    else
                        if(kw>=251 && kw<=500)
                    {
                        pago = kw * 0.85;
                    }
                    else
                        if(kw>=501 && kw<=1200)
                    {
                        pago = kw * 1.5;
                    }
                    else
                        if(kw>=1201 && kw <= 2100)
                    {
                        pago = kw * 2.5;
                    }
                    else
                        if(kw>=2101)
                    {
                        pago = kw * 3.00;
                    }
                break;

                case "Negocio":
                    if (kw >= 0 && kw <= 250)
                    {
                        pago = kw * 5;
                    }
                    else
                        if (kw >= 251 && kw <= 500)
                    {
                        pago = kw * 5;
                    }
                    else
                        if (kw >= 501 && kw <= 1200)
                    {
                        pago = kw * 5;
                    }
                    else
                        if (kw >= 1201 && kw <= 2100)
                    {
                        pago = kw * 5;
                    }
                    else
                        if (kw >= 2101)
                    {
                        pago = kw * 5;
                    }
                    break;
            }
        }
    }
}
