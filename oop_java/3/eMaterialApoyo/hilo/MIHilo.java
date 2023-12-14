package HiloEjemplo;

public class MIHilo extends Thread{

    MIHilo(String name){
        // super para llamar a la version del constructo de Thread
        super(name);
    }

    // punto de entrada del hilo
    public void run(){
        System.out.println(getName()+"iniciando.");

        //ExtendThread hereda de Thread, puede llamar directamente
        // a todos los metodos de Thread
        try {
            for (int i = 0; i < 10; i++) {
                Thread.sleep(4000);
                System.out.println("En " + getName() + " el recuento es " + i);
            }
        }catch (InterruptedException e){
            System.out.println(getName() + " interrumpido. " + e );
        }
        System.out.println(getName()+ " finalizado");
    }

}
