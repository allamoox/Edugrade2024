public class Utilities {
    public void openDoor(){
        System.out.println("Door is open");
    }
    public void closeDoor(){
        System.out.println("Door is closed");
    }
    public void openWindow(){
        System.out.println("Window is open");
    }
    public void closeWindow(){
        System.out.println("Window is closed");
    }
    public void openLight(){
        System.out.println("Light is open");
    }
    public void closeLight(){
        System.out.println("Light is closed");
    }
    public void openAll(){
        openWindow();
        openDoor();
        openLight();
        System.out.println("EveryThing is opened");
    }
    public void closeAll(){
        closeDoor();
        closeWindow();
        closeLight();
        System.out.println("EveryThing is closed");
    }
}
