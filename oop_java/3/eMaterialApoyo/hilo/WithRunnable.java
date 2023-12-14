/***
 * Se usa la interfaz runnable
 *
 */

package HiloEjemplo;

public class WithRunnable implements Runnable{

    @Override
    public void run() {
        try {
            for (int i = 0; i < 5; i++) {
                System.out.println(i + " " + Thread.currentThread().getName() );
                Thread.sleep(2000);
            }
        }catch (InterruptedException e){
            System.out.println("Exception: " +e);
        }
        System.out.println("Termina thread " + Thread.currentThread().getName());
    }
}
