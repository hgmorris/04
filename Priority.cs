namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add people to the queue and the one with the highest priority gets dequeued first
        // Expected Result: Job
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Bob",7);
        priorityQueue.Enqueue("Job",8);
        priorityQueue.Enqueue("Carl",5);
        Console.WriteLine(priorityQueue.Dequeue());
        

        // Defect(s) Found: None :)

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        var priorityQueue1 = new PriorityQueue();
        Console.WriteLine(priorityQueue1.Dequeue());

        // Defect(s) Found: None :)

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Both Job and Carl have the same level of priority, but since Job was first in the queue before
        // Carl, Job will go first and be dequeued first
        // Expected Result: Job
        Console.WriteLine("Test 3");
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Bob", 4);
        priorityQueue2.Enqueue("Job",6);
        priorityQueue2.Enqueue("Carl",6);
        Console.WriteLine(priorityQueue2.Dequeue());
        
        // Defect(s) Found: None :)
    }
}