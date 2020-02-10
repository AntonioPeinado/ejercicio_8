using System;

class MainClass {
  public static void Main (string[] args) {
		  Par<int,string> mipar = new Par<int,string>(1,"A");
			 Console.WriteLine (mipar.getAnios());
      Console.WriteLine (mipar.getNombre());
    Console.WriteLine ("Hello World");
  }
 class Par<T,K>{
        private T _anios;
        private K _nombre;

        public Par(T anios,K nombre) {
            this._anios = anios;
            this._nombre = nombre;
        }
        public T getAnios() {
            return this._anios;
        }
         public K getNombre () {
            return this._nombre;
        }
    }	
} 