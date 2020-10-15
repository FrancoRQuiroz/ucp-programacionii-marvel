public class Personaje{
    private string Nombre;
    private int PrimeraAparicion;
    private string Universo;
    private int Stamina;

    #region Constructores
    public Personaje(){
        this.Nombre = "";
        this.PrimeraAparicion = 0;
        this.Universo = "";
        this.Stamina = 0;
    }
    public Personaje(string nombre, int estreno, string universo, int stamina){
        this.Nombre = nombre;
        this.PrimeraAparicion = estreno;
        this.Universo = universo;
        this.Stamina = stamina;
    }
    #endregion
    #region  Get & Set
    //set 
    public void SetNombre(string nombre){
        this.Nombre = nombre;
    }
    public void SetPrimeraAparicion(int estreno){
        this.PrimeraAparicion = estreno;
    }
    public void SetUniverso(string universo){
        this.Universo = universo;
    }
    public void SetStamina(int stamina){
        this.Stamina = stamina;
    }
    //get 
    public string GetNombre(){
        return this.Nombre;
    }
    public int GetPrimeraAparicion(){
        return this.PrimeraAparicion;
    }
    public string GetUniverso(){
        return this.Universo;
    }
    public int GetStamina(){
        return this.Stamina;
    }
    #endregion
    #region  Metodos
    public virtual void Atacar(){

    }
    #endregion
}