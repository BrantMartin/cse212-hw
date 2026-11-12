using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Try to get the next person from an empty queue
    // Expected Result: Throw InvalidOperationException with appropriate error message.
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }

    }

    [TestMethod]
    // Scenario: Enqueue multiple people and make sure that they are enqueued to the back of the queue
    // Expected Result: When dequeued the person that was enqueued first with highest priority should be dequeued.
    // Defect(s) Found: A defect was that Dequeue was changing the priority Index even if it was equal. When that
    // happened, the person with high priority that was enqueued first was not being dequeued first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("HighPriority1", 5);
        priorityQueue.Enqueue("LowPriority1", 1);
        priorityQueue.Enqueue("HighPriority2", 5);
        priorityQueue.Enqueue("LowPriority2", 1);
        priorityQueue.Enqueue("LowPriority3", 1);
        Assert.AreEqual("HighPriority1", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}