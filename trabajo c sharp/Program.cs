﻿using System;
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

                area = Math.PI * Math.Pow(radio, 2);

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
            
            
            {
                Console.WriteLine("ejercicio 21");
                /* 21. Pedir dos números y decir cuál es el mayor o si son iguales. */


                double num1, num2;

                Console.WriteLine("digite su numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("escriba segundo numero");
                num2 = double.Parse(Console.ReadLine());

                if(num1 == num2){
                    Console.WriteLine("los numeros son iguales");
                }
                if(num1 > num2){
                    Console.WriteLine("el  primer numero es mayor");
                }
                if(num1 < num2){
                    Console.WriteLine("el segundo numero es mayor");
                }
            }

            {
                Console.WriteLine("ejercicio 22");
                /* 22. Pedir dos números y mostrarlos ordenados de mayor a menor. */


                double num1, num2;

                Console.WriteLine("digite su numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("escriba segundo numero");
                num2 = double.Parse(Console.ReadLine());

                if(num1 > num2) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}",num1, num2);
                }else{
                    Console.WriteLine("el orden mayor a menor es {0}, {1} ",num2, num1);
                }

            }

            {
                Console.WriteLine("ejercicio 23");
                /* 23. Pedir tres números y mostrarlos ordenados de mayor a menor. */


                double num1, num2, num3;

                Console.WriteLine("digite su primer numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("digite su segundo numero");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("digite su tercer numero");
                num3 = double.Parse(Console.ReadLine());

                if(num1 < num2 & num2 < num3 & num3 > num1) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}, {2}",num3, num2, num1);
                }

                if(num1 < num2 & num2 > num3 & num3 > num1) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}, {2}",num2, num3, num1);
                }

                if(num1 > num2 & num2 < num3 & num3 > num1) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}, {2}",num3, num1, num2);
                }

                if(num1 < num2 & num2 > num3 & num3 < num1) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}, {2}",num2, num1, num3);
                }

                if(num1 > num2 & num2 < num3 & num3 < num1) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}, {2}",num1, num3, num2);
                }

                if(num1 > num2 & num2 > num3 & num3 < num1) {
                    Console.WriteLine("el orden de mayor a menor es {0}, {1}, {2}",num1, num2, num3);
                }
            }

            {
                Console.WriteLine("ejercicio 24");
                /* 24. Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene. */


                double num1;

                Console.WriteLine("digite un numero entre 0 y 9.999");
                num1 = double.Parse(Console.ReadLine());

                if(num1 > 0 & num1 < 9) {
                    Console.WriteLine("el numero tiene 1 cifra");
                }
                if(num1 > 10 & num1 < 99) {
                    Console.WriteLine("el numero tiene 2 cifra");
                }
                if(num1 > 100 & num1 < 999) {
                    Console.WriteLine("el numero tiene 3 cifra");
                }
                if(num1 > 1000 & num1 < 9999) {
                    Console.WriteLine("el numero tiene 4 cifra");
                }
            }

            {
                Console.WriteLine("ejercicio 25");
                /* 25. Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 – 2,9), Suficiente (3 – 4,5) y Bien (4,6 – 5) */


                double num1;

                Console.WriteLine("digite su nota");
                num1 = double.Parse(Console.ReadLine());

                if(num1 >= 0 && num1 < 3) {
                    Console.WriteLine("la nota es insuficiente");
                }else if(num1 >= 3 && num1 < 4.6) {
                    Console.WriteLine("la nota es suficiente");
                }else if(num1 >= 4.6 && num1 <= 5) {
                    Console.WriteLine("la nota es bien");
                }
                else {
                    Console.WriteLine("Rando incorecto");
                }
            }

            {
                Console.WriteLine("ejercicio 26");
                /* 26. Pedir una nota numérica entera entre 0 y 10, y mostrar dicha nota de la forma: cero, uno, dos, tres... */


                int num1;

                Console.WriteLine("digite su nota entre 1 y 10");
                num1 = int.Parse(Console.ReadLine());

                if(num1 == 0) {
                    Console.WriteLine("cero");
                }
                if(num1 == 1) {
                    Console.WriteLine("uno");
                }
                if(num1 == 2) {
                    Console.WriteLine("dos");
                }
                if(num1 == 3) {
                    Console.WriteLine("tres");
                }
                if(num1 == 4) {
                    Console.WriteLine("cuatro");
                }
                if(num1 == 5) {
                    Console.WriteLine("cinco");
                }
                if(num1 == 6) {
                    Console.WriteLine("seis");
                }
                if(num1 == 7) {
                    Console.WriteLine("siete");
                }
                if(num1 == 8) {
                    Console.WriteLine("ocho");
                }
                if(num1 == 9) {
                    Console.WriteLine("nueve");
                }
                if(num1 == 10) {
                    Console.WriteLine("diez");
                }
            }

            {
                Console.WriteLine("ejercicio 27");
                /* 27. Pedir un número y decir si es par o impar. */


                double num1;

                Console.WriteLine("digite su numero");
                num1 = double.Parse(Console.ReadLine());

                if((num1 % 2) == 0){
                    Console.WriteLine("es un numero par");
                }else{
                    Console.WriteLine("no es un numero par");
                }
            }
            Console.ReadKey();
        }
    }
}
