public class Solution {
    public int PassThePillow(int n, int time) {
        int interval = n - 1;

        int cycle = time / interval;
        bool isMovingForward = (cycle % 2) == 0;

        int remainingTime = time % interval;
        return isMovingForward ? remainingTime + 1 : n - remainingTime;
    }
}