public class Villano{
     #region Atributos
    private string Nombrev;
    private int PrimeraAparicionV;
    private string UniversoV;
    private int StaminaV;
    #endregion

    #region Constructor
    public Villano(){
        this.Nombrev = "";
        this.PrimeraAparicionV = 0;
        this.UniversoV = "";
        this.StaminaV = 0;
    }
    public Villano(string nombre, int aparicion, string universo, bool tipo,int vidas, int stamina, int usos){
        this.Nombrev = nombre;
        this.PrimeraAparicionV = aparicion;
        this.UniversoV = universo;
        this.StaminaV = stamina;
    }
    #endregion

    #region Get & Set
    //Setters
    public void SetNombrev(string nombre){
        this.Nombrev = nombre;
    }
    public void SetAparicionV(int aparicion){
        this.PrimeraAparicionV = aparicion;
    }
    public void SetUniversoV(string universo){
        this.UniversoV = universo;
    }
    
    public void SetStaminaV(int stamina){
        this.StaminaV = stamina;
    }
    //Gettters
    public string GetNombreV(){
        return this.Nombrev;
    }
    public int GetAparicionV(){
        return this.PrimeraAparicionV;
    }
    public string GetUniversoV(){
        return this.UniversoV;
    }
    
    
    public int GetStaminaV(){
        return this.StaminaV;
    }
    #endregion
    
    #region Metodos
    public void Atacar(){
        
    }
    #endregion

}