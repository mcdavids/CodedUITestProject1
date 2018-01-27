Feature: Create Task
    As a ToDo App user
    I should be able to create a task So I can manage my task
   
@mytag
Scenario: The user should always see the ‘My Tasks’ link on the NavBar
    Given I have clicked the 'My Tasks' link 
    And I have been redirected to a page with all the created tasks so far
    Then the displayed message should be ‘Hey Clay Davidson, this is your todo list for today:’
    Given I have entered a new task with at least 3 characters and no more than 250 characters
    When I Add a task by hitting enter
    And I also click the add task button
    Then the task should be appended on the list of created tasks