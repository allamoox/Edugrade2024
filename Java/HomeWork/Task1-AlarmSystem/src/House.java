public class House {

    Bedroom bedroom = new Bedroom();
    Garage garage = new Garage();
    Kitchen kitchen = new Kitchen();
    HallWay hallway = new HallWay();

    public void controlBedroom() {
        bedroom.myBedroom.openDoor();
    }
    public void controlGarage() {
        garage.myGarage.openWindow();
    }
    public void controlKitchen() {
        kitchen.myKitchen.openWindow();
    }
    public void controlHallway() {
        hallway.myHallWay.openWindow();
    }
}



