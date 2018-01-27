using System;
using TechTalk.SpecFlow;

namespace CodedUITestProject1
{
    [Binding]
    public class CreateTaskSteps
    {
        [Given(@"I have clicked the '(.*)' link")]
        public void GivenIHaveClickedTheLink(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have been redirected to a page with all the created tasks so far")]
        public void GivenIHaveBeenRedirectedToAPageWithAllTheCreatedTasksSoFar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a new task with at least (.*) characters and no more than (.*) characters")]
        public void GivenIHaveEnteredANewTaskWithAtLeastCharactersAndNoMoreThanCharacters(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Add a task by hitting enter")]
        public void WhenIAddATaskByHittingEnter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I also click the add task button")]
        public void WhenIAlsoClickTheAddTaskButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the displayed message should be ‘Hey Clay Davidson, this is your todo list for today:’")]
        public void ThenTheDisplayedMessageShouldBeHeyClayDavidsonThisIsYourTodoListForToday()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the task should be appended on the list of created tasks")]
        public void ThenTheTaskShouldBeAppendedOnTheListOfCreatedTasks()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
