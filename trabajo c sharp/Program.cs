using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("ejercicio 1");
                /* 1. Hacer un algoritmo que declare una variable para guardar el número de horas de estudio,
                * y otra para guardar el nombre. Escribir ambos datos */


                string nombre;
                double horas_estudiadas;

                Console.WriteLine("digite su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("cuantas horas estudio");
                horas_estudiadas = double.Parse(Console.ReadLine());

                Console.WriteLine("su nombre es {0} y las horas que estudio fueron {1}", nombre, horas_estudiadas);
            }


            {
                Console.WriteLine("ejercicio 2");
                /* 2. Hacer un algoritmo que lea dos números enteros A y B y muestre el doble de su suma */


                int num1, num2, total;

                Console.WriteLine("digite su primer numero");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("digite su segundo numero");
                num2 = int.Parse(Console.ReadLine());

                total = num1 + num2;

                Console.WriteLine("el total de la suma es igual a {0}", total);
            }


            {
                Console.WriteLine("ejercicio 3");
                /* 3. Hacer un algoritmo que declare una variable para guardar el promedio del semestre,
                 * otra para guardar el nombre de un estudiante y otra para guardar el número de notas perdidas */


                string nombre;
                int notas_perdidas;
                double promedio;

                Console.WriteLine("digite su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("numero de notas perdidas");
                notas_perdidas = int.Parse(Console.ReadLine());

                Console.WriteLine("digite su promedio");
                promedio = double.Parse(Console.ReadLine());

                Console.WriteLine("su nombre es {0}, su promedio es de {1} y su total de notas perdidas es de {2}", nombre, promedio, notas_perdidas);
            }


            {
                Console.WriteLine("ejercicio 4");
                /* 4. Hacer un algoritmo que lea dos números enteros A y B y muestre el resultado de
                 * realizar: (A + B) *2 +10 */


                int num1, num2, totals, totalm, totals2;

                Console.WriteLine("digite su primer numero");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("digite su segundo numero");
                num2 = int.Parse(Console.ReadLine());

                totals = num1 + num2;

                totalm = (num1 + num2) * 2;

                totals2 = totalm + 10;

                Console.WriteLine("el total de la suma de ambos numeros es {0}, el total de la suma por dos es {1} y el total de la multiplicacion mas dies es igual a {2}", totals, totalm, totals2);
            }


            {
                Console.WriteLine("ejercicio 5");
                /* 5. Hacer un algoritmo que declare una variable para guardar el nombre de una persona,
                 * otra para guardar la comida preferida y otra para guardar la
                 * cantidad de dinero que posee. */

                string nombre, comida_fav;
                double dinero;

                Console.WriteLine("digite su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("cual es su comida favorita");
                comida_fav = Console.ReadLine();

                Console.WriteLine("cuanto dinero tiene (pesos)");
                dinero = double.Parse(Console.ReadLine());

                Console.WriteLine("su nombre es {0}, su comida favorita es {1} y tiene {2} pesos ", nombre, comida_fav, dinero);
            }

            {
                Console.WriteLine("ejercicio 6");
                /* 6. Algoritmo que lea el nombre de un articulo,la cantidad a comprar, el valor unitario 
                y muestre el nombre y el total a pagar */


                string articulo;
                int cantidad;
                double valor, total;

                Console.WriteLine("Que articulo va a comprar");
                articulo = Console.ReadLine();

                Console.WriteLine("Cuantos va a comprar");
                cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Cual es el valor unitario de el articulo");
                valor = double.Parse(Console.ReadLine());

                total = valor * cantidad;

                Console.WriteLine("Usted va a comprar {0} y el total a pagar es {1}", articulo, total);
            }


            {
                Console.WriteLine("ejercicio 7");
                /*  7. Hacer un algoritmo para leer dos numeros los cuales seran tecleados por el usuario */


                double num1, num2, resultado;

                Console.WriteLine("Digite el primer numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el segundo numero");
                num2 = double.Parse(Console.ReadLine());

                resultado = num1 + num2;

                Console.WriteLine("el resultado de sumar {0} + {1} es {2} ", num1, num2, resultado);
            }


            {
                Console.WriteLine("ejercicio 8");
                /* 8. Hacer un algoritmo que lea el nombre de una persona y número de horas que estudia en la semana */


                string nombre;
                double lunes, martes, miercoles, jueves, viernes, total;

                Console.WriteLine("Cual es su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Cuantas horas estudia el lunes");
                lunes = double.Parse(Console.ReadLine());

                Console.WriteLine("Cuantas horas estudia el martes");
                martes = double.Parse(Console.ReadLine());

                Console.WriteLine("Cuantas horas estudia el miercoles");
                miercoles = double.Parse(Console.ReadLine());

                Console.WriteLine("Cuantas horas estudia el jueves");
                jueves = double.Parse(Console.ReadLine());

                Console.WriteLine("Cuantas horas estudia el viernes");
                viernes = double.Parse(Console.ReadLine());

                total = lunes + martes + miercoles + jueves + viernes;

                Console.WriteLine("Su nombre es {0} y el total de horas que estudia a la semana es {1}", nombre, total);
            }


            {
                Console.WriteLine("ejercicio 9");
                /* 9. Hacer un algoritmo que lea el nombre de un estudiante, la cantidad de materias perdidas 
                 * y la cantidad de materias ganadas */


                string nombre;
                int mp, mg;

                Console.WriteLine("Cual es su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Cuantas materias perdio");
                mp = int.Parse(Console.ReadLine());

                Console.WriteLine("Cuantas materias gano");
                mg = int.Parse(Console.ReadLine());

                Console.WriteLine("Su nombre es {0}, perdio {1} materias y gano {2}", nombre, mp, mg);
            }


            {
                Console.WriteLine("ejercicio 10");
                /* 10. Hacer un algoritmo que lea el alto y el ancho de un rectángulo 
                 * y muestre su área y su perímetro */


                double alto, ancho, area, perimetro;

                Console.WriteLine("digite el valor para el alto del rectangulo");
                alto = double.Parse(Console.ReadLine());

                Console.WriteLine("digite el valor para el ancho del rectangulo");
                ancho = double.Parse(Console.ReadLine());

                area = ancho * alto;
                perimetro = (ancho + alto) * 2;

                Console.WriteLine("el area del rectangulo es {0} y el perimetro es de {1}", area, perimetro);
            }


            {
                Console.WriteLine("ejercicio 11");
                /* 11. Hacer un algoritmo que lea dos números enteros A y B y muestre su diferencia */


                double num1, num2, total;

                Console.WriteLine("escriba el primer digito");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("escriba el segundo digito");
                num2 = double.Parse(Console.ReadLine());

                total = num1 - num2;

                Console.WriteLine("La resta entre los dos numeros es de {0}", total);
            }


            {
                Console.WriteLine("ejercicio 12");
                /* 12. Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada
                 * y el número de horas que trabajó. Se debe mostrar el nombre y el pago de la persona */


                string nombre;
                double valor_hora, num_horas, total;

                Console.WriteLine("Cual es su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("digite el valor de la hora trabajada");
                valor_hora = double.Parse(Console.ReadLine());

                Console.WriteLine("digite el numero de horas que trabajo");
                num_horas = double.Parse(Console.ReadLine());

                total = valor_hora * num_horas;

                Console.WriteLine("Su nombre es {0} y su pago es de {1}", nombre, total);
            }


            {
                Console.WriteLine("ejercicio 13");
                /* 13. Pedir el radio de un círculo y calcular su área. A=PI*r^2 */


                double radio, area;

                Console.WriteLine("Digite el valor del radio de un circulo");
                radio = double.Parse(Console.ReadLine());

                area = Math.PI * radio * 2;

                Console.WriteLine("El area del circulo es {0}", area);
            }


            {
                Console.WriteLine("ejercicio 14");
                /* 14. Pedir el radio de una circunferencia y calcular su longitud */


                double radio, longitud;

                Console.WriteLine("Digite el valor del radio de su circulo");
                radio = double.Parse(Console.ReadLine());

                longitud = 2 * Math.PI * radio;

                Console.WriteLine("La longitud de su circulo es de {0}", longitud);
            }


            {
                Console.WriteLine("ejercicio 15");
                /* 15. Pedir el lado de un cuadrado, mostrar su área y su perímetro */


                double lado, area, perimetro;

                Console.WriteLine("Digite el valor para el lado de un cuadrado");
                lado = double.Parse(Console.ReadLine());

                area = lado * lado;

                perimetro = lado * 4;

                Console.WriteLine("El area del cuadrado es de {0} y el perimetro es de {1}", area, perimetro);
            }


            {
                Console.WriteLine("ejercicio 16");
                /* 16. Calcular el área de un rectángulo de lados X e Y */


                double ladoX, ladoY, area;

                Console.WriteLine("Digite el valor del lado X de su rectangulo");
                ladoX = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor del lado y de su rectangulo");
                ladoY = double.Parse(Console.ReadLine());

                area = ladoY * ladoX;

                Console.WriteLine("El area de su rectangulo es de {0}", area);
            }

            {
                Console.WriteLine("ejercicio 17");
                /* 17. Pedir dos números y decir si son iguales o no. */


                double num1, num2;

                Console.WriteLine("digite primer numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("digite numero 2");
                num2 = double.Parse(Console.ReadLine());

                if(num1 == num2)
                {
                    Console.WriteLine("los numeros son iguales");
                }else{
                    Console.WriteLine("los numeros son diferentes");
                }


                {

                    Console.WriteLine("ejercicio 18");
                    /* 18. Pedir un número e indicar si es positivo o negativo */


                    double num1;

                    Console.WriteLine("digite su numero");
                    num1 = double.Parse(Console.ReadLine());

                    if(num1 >= 0)
                    {
                        Console.WriteLine("el munero es positivo");
                    }else{
                        Console.WriteLine("el numero es negativo");
                    }

                    {
                            Console.WriteLine("ejercicio 19");
                        /* 19. Pedir dos números y decir si uno es múltiplo del otro */


                        double num1, num2;

                        Console.WriteLine("digite su numero");
                        num1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("escriba segundo numero");
                        num2 = double.Parse(Console.ReadLine());
    
                        if(num1 % num2 == 0){
                            Console.WriteLine("los numeros son multiplos");
                        }else{
                            Console.WriteLine("los numeros no son multiplos");
                        }

                        {
                            Console.WriteLine("ejercicio 20");
                            /* 20. Pedir dos números y decir cuál es el mayor. */


                            double num1, num2;

                            Console.WriteLine("digite su numero");
                            num1 = double.Parse(Console.ReadLine());

                            Console.WriteLine("escriba segundo numero");
                            num2 = double.Parse(Console.ReadLine());
    
                            if(num1 > num2){
                                Console.WriteLine("el  primer numero es mayor");
                            }else{
                                Console.WriteLine("el segundo numero es mayor");
                            }
                        }
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
