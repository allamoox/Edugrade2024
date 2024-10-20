public class AlarmSystem {
    boolean fire =false;
    boolean burglary =false;
    boolean motion =false;

    public void activateAlarm(){
        System.out.println("Alarm Activated");
    }

    public void deactivateAlarm(){
        System.out.println("Alarm Deactivated");
    }

    public void checkSensor(){
        if(fire){
            System.out.println("Alarm Fire");
        }
        if(burglary){
            System.out.println("Alarm Burglary");
        }
        if(motion){
            System.out.println("Alarm Motion");
        }
    }

    }
