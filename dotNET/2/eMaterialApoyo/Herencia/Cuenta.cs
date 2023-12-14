namespace Herencia
{
    abstract class Cuenta
    {
        protected abstract void Deposito();
        protected abstract void Retiro();

    }

    class DeAhorros : Cuenta
    {
        protected override void Deposito()
        {
            throw new NotImplementedException();
        }

        protected override void Retiro()
        {
            throw new NotImplementedException();
        }
    }

    class Inversiones : Cuenta
    {
        protected override void Deposito()
        {
            throw new NotImplementedException();
        }

        protected override void Retiro()
        {
            throw new NotImplementedException();
        }
    }

    class Maestra : DeAhorros
    {
    
    }

}
