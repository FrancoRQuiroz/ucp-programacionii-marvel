public class SuperHeroe{
    #region Atributos
    private string Nombre;
    private int PrimeraAparicion;
    private string Universo;
    private SuperPoder Poder;
    private int CantidadVidas;
    private int Stamina;
    #endregion

    #region Constructor
    public SuperHeroe(){
        this.Nombre = "";
        this.PrimeraAparicion = 0;
        this.Universo = "";
        this.Poder = new SuperPoder();
        this.CantidadVidas = 0;
        this.Stamina = 0;
    }
    public SuperHeroe(string nombre, int aparicion, string universo, SuperPoder poder,int vidas, int stamina){
        this.Nombre = nombre;
        this.PrimeraAparicion = aparicion;
        this.Universo = universo;
        this.Poder = poder;
        this.CantidadVidas = vidas;
        this.Stamina = stamina;
    }
    #endregion

    #region Get & Set
    //Setters
    public void SetNombre(string nombre){
        this.Nombre= nombre;
    }
    public void SetAparicion(int aparicion){
        this.PrimeraAparicion = aparicion;
    }
    public void SetUniverso(string universo){
        this.Universo = universo;
    }
    public void SetCantidadVidas(int vidas){
        this.CantidadVidas = vidas;
    }
    public void SetStamina(int stamina){
        this.Stamina = stamina;
    }
    public void SetSuperPoder(SuperPoder poder){
        this.Poder = poder;
    }
    //Gettters
    public string GetNombre(){
        return this.Nombre;
    }
    public int GetAparicion(){
        return this.PrimeraAparicion;
    }
    public string GetUniverso(){
        return this.Universo;
    }
    public int GetCantidadVidas(){
        return this.CantidadVidas;
    }
    public int GetStamina(){
        return this.Stamina;
    }
    public SuperPoder GetSuperPoder(){
        return this.Poder;
    }
    #endregion

    #region Metodos
    public void Atacar(){

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