public class Combate{
    #region Atributos
    private SuperHeroe Heroe;

    private Villano Villano;
    private int CantidadUsosSuperPoder;
    #endregion

    #region  Constructor
    public Combate(){
        this.Heroe = new SuperHeroe();
        this.Villano = new Villano();
        this.CantidadUsosSuperPoder = 0;
    }
    public Combate(SuperHeroe heroe, Villano villano, int cantidadusospoder){
        this.Heroe = heroe;
        this.Villano = villano;
        this.CantidadUsosSuperPoder = cantidadusospoder;
    }
    #endregion

    #region Set & Get
    //Set
    public void SetCantidadUsosPoder(int cantidadusospoder){
        this.CantidadUsosSuperPoder = cantidadusospoder;
    }
    public void SetHeroe(SuperHeroe heroe){
        this.Heroe = new SuperHeroe();
    }
    public void SetVillano(Villano villano){
        this.Villano = new Villano();
    }
    //Get
    public int GetCantidadUsosPoder(){
        return this.CantidadUsosSuperPoder;
    }
    public SuperHeroe GetSuperHeroe(){
        return this.Heroe;
    }
    public Villano GetVillano(){
        return this.Villano;
    }
    #endregion

    #region Metodos
    public void Comenzar(){

    }
    public void Terminar(){

    }
    public void Turno(){

    }
    #endregion
}