public class SuperHeroe:Personaje{
    #region Atributos
    private SuperPoder Poder;
    private int CantidadVidas;
    
    #endregion

    #region Constructor
    public SuperHeroe( ):base(){
        this.Poder = new SuperPoder();
        this.CantidadVidas = 0;
    }
    public SuperHeroe(string nombre, int estreno, string universo,int stamina, SuperPoder poder,int vidas):base( nombre,  estreno,  universo, stamina){
        this.Poder = poder;
        this.CantidadVidas = vidas;
        
    }
    #endregion

    #region Get & Set
    //Setters
       public void SetCantidadVidas(int vidas){
        this.CantidadVidas = vidas;
    }
   
    public void SetSuperPoder(SuperPoder poder){
        this.Poder = poder;
    }
    //Gettters
   
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
   
    public SuperPoder GetSuperPoder(){
        return this.Poder;
    }
    #endregion

    #region Metodos
    public override void Atacar(){

    }
    public void UsarItem(){

    }
    public void Defender(){

    }
    public void UsarSuperPoder(){

    }
    public Item ObtenerItem(){
        return new Item();
    }
    #endregion

}