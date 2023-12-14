/** 
 * Jerarquia de herencia de clases abstractas
 * que implementan metodos abstractos
 */
namespace Herencia
{
    
    abstract class Vertebrado
    {
        protected abstract void generarColumna();
        protected abstract void respirar();
    }


    /* *****  *****  *****  *****  *****  *****  *****  ***** */
    abstract class Mamifero : Vertebrado
    {
        protected override abstract void generarColumna();
        protected override void respirar() {    /* Implemented */  }    // override invalida la implementacion abstracta
    }


    abstract class Ave : Vertebrado
    {
        protected abstract override void generarColumna();
        protected override void respirar() {    /* Implemented */  }    // override
        protected abstract void volar();
    }


    abstract class Pez : Vertebrado
    {
        protected override abstract void generarColumna();
        protected override void respirar() {    /* Implemented */  }    // override
    }


    /* *****  *****  *****  *****  *****  *****  *****  ***** */
    class Perro : Mamifero
    {
        protected override void generarColumna() {    /* Implemented */  }
    }

    class Tigre : Mamifero
    {
        protected override void generarColumna() {    /* Implemented */  }
    }

    class Tucan : Ave
    {
        protected override void generarColumna() {    /* Implemented */  }
        protected override void volar() {    /* Implemented */  }
    }

    class Canario : Ave
    {
        protected override void generarColumna() {    /* Implemented */  }
        protected override void volar() {    /* Implemented */  }
    }

    class Trucha : Pez
    {
        protected override void generarColumna() {    /* Implemented */  }
    }

    class Sardina : Pez
    {
        protected override void generarColumna() {    /* Implemented */  }
    }
}
