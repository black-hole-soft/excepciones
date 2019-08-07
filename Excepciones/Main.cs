// Ejemplo útil para comprender la fundamentación
// y manejo de excepciones en C#.
// En este caso, se crea una excepción personalizada
// que atiende una situación muy particular: la detección
// de un número par.

// Luis Casillas 2005

using System;

namespace Excepciones3{
	
	class MiExcepcion:Exception{
		internal MiExcepcion(string mensaje):base(mensaje){}
	}
	class EsTri:Exception{
		internal EsTri(string mensaje):base(mensaje){}
	}
	class EsEsc:Exception{
		internal EsEsc(string mensaje):base(mensaje){}
	}
	class EsEqu:Exception{
		internal EsEqu(string mensaje):base(mensaje){}
	}
	class EsIso:Exception{
		internal EsIso(string mensaje):base(mensaje){}
	}
	class EsRec:Exception{
		internal EsRec(string mensaje):base(mensaje){}
	}
	class MainClass{
		Random r=new Random();
		int a,b,c;
		public int A{
			get{
				return a;
			}
		}
		public int B{
			get{
				return b;
			}
		}
		public int C{
			get{
				return c;
			}
		}
		public MainClass(){			
			a=r.Next(20);
			b=r.Next(20);
			c=r.Next(20);
		}
		public static void Main(string[] args){
			MainClass mc=new MainClass();
			Console.WriteLine();
			try{
				if(mc.a==mc.b&&mc.b==mc.c)throw(new EsEqu("Es Equilatero"));
				if(mc.a==mc.b&&mc.a!=mc.c)throw(new EsEqu("Es Isoceles"));
				if(mc.a==mc.c&&mc.a!=mc.b)throw(new EsEqu("Es Isoceles"));
				if(mc.c==mc.b&&mc.a!=mc.c)throw(new EsEqu("Es Isoceles"));
				if(mc.a!=mc.b&&mc.b!=mc.c&&mc.a!=mc.c)throw(new EsEsc("Es Escaleno"));
				if(mc.a>0&&mc.b>0&&mc.c>0)throw(new EsTri("Es triangulo"));
			}catch(EsTri t){
				Console.WriteLine("{0}",t);
			}
			catch(EsEsc e){
				Console.WriteLine("{0}",e);
			}
			catch(EsEqu eq){
				Console.WriteLine("{0}",eq);
			}
			catch(EsIso i){
				Console.WriteLine("{0}",i);
			}
			catch(EsRec r){
				Console.WriteLine("{0}",r);
			}
			Console.ReadLine();
		}
	}
}
