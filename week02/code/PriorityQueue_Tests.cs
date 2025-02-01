using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items at the end of the queue
    // Expected Result: The item with the highest priority (the highest number) should be dequeued first
    // Defect(s) Found: The Dequeue function was not removing items from the queue, and the loop was excluding the last item
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Item-A", 2);
        priorityQueue.Enqueue("Item-B", 6);
        priorityQueue.Enqueue("Item-C", 4);

        Assert.AreEqual("Item-B", priorityQueue.Dequeue());
        Assert.AreEqual("Item-C", priorityQueue.Dequeue());
        Assert.AreEqual("Item-A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with the same priority and dequeue them
    // Expected Result: Item with the same priority must be dequeued in order starting in front of the queue 
    // Defect(s) Found: The Dequeue function was not correctly handling items with the same priority
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item-D", 3);
        priorityQueue.Enqueue("Item-E", 3);
        priorityQueue.Enqueue("Item-F", 3);

        Assert.AreEqual("Item-D", priorityQueue.Dequeue());
        Assert.AreEqual("Item-E", priorityQueue.Dequeue());
        Assert.AreEqual("Item-F", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Add items with different priorities and dequeue them
    // Expected Result: Items with highest priority will be dequeued first, and with the same priority will be dequeued in order starting
    // in front of the queue 
    // Defect(s) Found: The Dequeue function was not handling correctly mixed priority items
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item-G", 3);
        priorityQueue.Enqueue("Item-H", 5);
        priorityQueue.Enqueue("Item-I", 5);
        priorityQueue.Enqueue("Item-J", 2);
        priorityQueue.Enqueue("Item-K", 5);

        Assert.AreEqual("Item-H", priorityQueue.Dequeue());
        Assert.AreEqual("Item-I", priorityQueue.Dequeue());
        Assert.AreEqual("Item-K", priorityQueue.Dequeue());
        Assert.AreEqual("Item-G", priorityQueue.Dequeue());
        Assert.AreEqual("Item-J", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: A message saying "The queue is empty"
    // Defect(s) Found: There was no error on this test
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var expection = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", expection.Message);
    }
}