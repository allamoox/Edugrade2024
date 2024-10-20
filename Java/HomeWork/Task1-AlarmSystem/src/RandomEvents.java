import java.util.Random;

public class RandomEvents {
    Random random = new Random();

    public boolean simulateFire(){
        return random.nextInt(10) >3;
    }

    public boolean simulateBurglary(){
        return random.nextInt(10) >4;
    }

    public boolean simulateMotion(){
        return random.nextInt(10) >2;
    }
}
