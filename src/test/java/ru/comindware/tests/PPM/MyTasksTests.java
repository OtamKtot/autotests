package ru.comindware.tests.PPM;

import io.qameta.allure.*;
import org.aeonbits.owner.ConfigFactory;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Tag;
import org.junit.jupiter.api.Test;
import ru.comindware.API.ObjectService;
import ru.comindware.API.ProcessObject;
import ru.comindware.API.UserTask;
import ru.comindware.config.CredentialsConfig;
import ru.comindware.tests.BaseTest;
import ru.comindware.pages.LoginPage;
import ru.comindware.pages.PPM.*;
import ru.comindware.utils.DateAndTimeUtils;

import java.time.LocalDate;
import java.util.HashMap;
import java.util.Map;

import static com.codeborne.selenide.Selenide.sleep;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.is;
import static org.hamcrest.Matchers.notNullValue;
import static ru.comindware.utils.RandomUtils.getRandomInt;
import static ru.comindware.utils.RandomUtils.getRandomString;


@Owner("Aantipov")
@Severity(SeverityLevel.BLOCKER)
@Feature("Сценарий ППМ")
@Story("Сценарий ППМ")
public class MyTasksTests extends BaseTest {
    DateAndTimeUtils dateAndTimeUtils = new DateAndTimeUtils();
    LoginPage loginPage = new LoginPage();
    MyTasks myTasks = new MyTasks();
    TechnicalRequirements technicalRequirements = new TechnicalRequirements();
    RateUrgency rateUrgency = new RateUrgency();
    OrganizeEvaluation organizeEvaluation = new OrganizeEvaluation();
    EstablishProject establishProject = new EstablishProject();
    TurnProject turnProject = new TurnProject();
    ProcessObject processObject = new ProcessObject();
    UserTask userTask = new UserTask();
    ObjectService objectService = new ObjectService();
    CredentialsConfig config = ConfigFactory.create(CredentialsConfig.class, System.getProperties());
    String loginProject = config.loginProject(),
            passwordProject = config.passwordProject(),
            loginDirector = config.loginDirector(),
            passwordDirector = config.passwordDirector(),
            fioDirector = config.fioDirector(),
            nameProject = getRandomString(10),
            codeProject = String.valueOf(getRandomInt(0, 999999));

    @Test
    @DisplayName("Создать заявку на проект")
    @Tag("PPM")
    void createTicket() {
        loginPage.login(loginProject, passwordProject);
        myTasks.CreateTicketOnProject()
                .WriteDescriptionAndCreate(nameProject)
                .OperationComplete()
                .RefreshList()
                .OpenTechnicalRequirements();
        technicalRequirements.WriteDescription(nameProject)
                .AddNewRecordToCollection()
                .FillFieldOnPopup()
                .CompleteTask()
                .OperationComplete();
        sleep(5000);
        myTasks.GoToMyTasks()
                .OpenRateUrgency();
        rateUrgency.CompleteTask()
                .OperationComplete();
        sleep(5000);
        myTasks.GoToMyTasks()
                .OpenOrganizeEvaluation();
        organizeEvaluation.CompleteTask();
        sleep(5000);
        myTasks.GoToMyTasks()
                .OpenEstablishProject();
        establishProject.FillFormField(nameProject, codeProject, fioDirector)
                .CompleteTask()
                .OperationComplete();
        myTasks.GoToMyTasks()
                .OpenTurnProject();
        turnProject.CompleteTask()
                .OperationComplete();
        myTasks.LogOut();
        sleep(5000);
        loginPage.login(loginDirector, passwordDirector);
        myTasks.OpenAppointDirector(nameProject, codeProject);
    }

    @DisplayName("Выполнить задачу оформление технических требований")
    @Tag("PPM")
    @Test
    void completeTechnicalRequirements() {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);
        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.9", nameProject);
        objectData.put("op.68", "admin");
        objectData.put("op.132", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("op.133", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("op.123", nameProject);
        objectData.put("op.15", "account.1");
        String processId = processObject.CreateWithData(loginProject, passwordProject, "pa.1", null, objectData, 0);
        String taskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId, is(notNullValue()));
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(taskId);
        technicalRequirements.WriteDescription(nameProject)
                .AddNewRecordToCollection()
                .FillFieldOnPopup()
                .CompleteTask()
                .OperationComplete();
        String objectId = userTask.GetBusinessObject(loginProject, passwordProject, taskId);
        objectService.DeleteObjectById(loginProject, passwordProject, objectId);
    }

    @DisplayName("Выполнить задачу 'Оценить срочность выполнения заявки'")
    @Tag("PPM")
    @Test
    void completeRateUrgency() {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);

        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.9", nameProject);
        objectData.put("op.68", "admin");
        objectData.put("op.132", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("op.133", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("op.123", nameProject);
        objectData.put("op.15", "account.1");
        String processId = processObject.CreateWithData(loginProject, passwordProject, "pa.1", null, objectData, 0);
        String taskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, taskId, true);
        String taskId1 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(taskId1);
        rateUrgency.CompleteTask()
                .OperationComplete();
        String objectId = userTask.GetBusinessObject(loginProject, passwordProject, taskId1);
        objectService.DeleteObjectById(loginProject, passwordProject, objectId);
    }

    @DisplayName("Выполнить задачу 'Организовать предпроектную оценку'")
    @Tag("PPM")
    @Test
    void completeOrganizeEvaluation() {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);

        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.9", nameProject);
        objectData.put("op.68", "admin");
        objectData.put("op.132", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("op.133", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("op.123", nameProject);
        objectData.put("op.15", "account.1");
        String processId = processObject.CreateWithData(loginProject, passwordProject, "pa.1", null, objectData, 0);
        String taskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, taskId, true);
        String taskId1 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        String objectId = userTask.GetBusinessObject(loginProject, passwordProject, taskId1);
        Map<String, String> objectData1 = new HashMap<>();
        objectData1.put("op.162", "true");
        objectService.EditObjectById(loginProject, passwordProject, objectId, objectData1);
        userTask.CompleteTask(loginProject, passwordProject, taskId1, true);
        String taskId2 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(taskId2);
        organizeEvaluation.CompleteTask()
                .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, objectId);
    }
    @DisplayName("Выполнить задачу ''Формирование проектов по заявке''")
    @Tag("PPM")
    @Test
    void completeEstablishProject() {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);

        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.9", nameProject);
        objectData.put("op.68", "admin");
        objectData.put("op.132", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("op.133", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("op.123", nameProject);
        objectData.put("op.15", "account.1");
        String processId = processObject.CreateWithData(loginProject, passwordProject, "pa.1", null, objectData, 0);
        String taskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, taskId, true);
        String taskId1 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId1, is(notNullValue()));
        String objectId = userTask.GetBusinessObject(loginProject, passwordProject, taskId1);
        Map<String, String> objectData1 = new HashMap<>();
        objectData1.put("op.162", "true");
        objectService.EditObjectById(loginProject, passwordProject, objectId, objectData1);
        String objectAlias = "ProjectDocument";
        Map<String, String> objectData3 = new HashMap<>();
        objectData3.put("ProjectRequest", objectId);
        objectData3.put("Type", "879022");
        objectService.CreateWithObjectAlias(loginProject, passwordProject, objectAlias, objectData3);
        userTask.CompleteTask(loginProject, passwordProject, taskId1, true);
        String taskId2 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId2, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, taskId2, true);
        String taskId3 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId3, is(notNullValue()));
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(taskId3);
        establishProject.FillFormField(nameProject, codeProject, fioDirector)
                .CompleteTask()
                .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, objectId);
    }
    @DisplayName("Выполнить задачу 'Включение проекта в план график'")
    @Tag("PPM")
    @Test
    void completeTurnProject() {
        LocalDate thirtyDaysAgo = LocalDate.now().minusDays(30);
        LocalDate thirtyDaysPlus = LocalDate.now().plusDays(30);

        Map<String, String> objectData = new HashMap<>();
        objectData.put("op.9", nameProject);
        objectData.put("op.68", "admin");
        objectData.put("op.132", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData.put("op.133", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData.put("op.123", nameProject);
        objectData.put("op.15", "account.1");
        String processId = processObject.CreateWithData(loginProject, passwordProject, "pa.1", null, objectData, 0);
        String taskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, taskId, true);
        String taskId1 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId1, is(notNullValue()));
        String objectId = userTask.GetBusinessObject(loginProject, passwordProject, taskId1);
        Map<String, String> objectData1 = new HashMap<>();
        objectData1.put("op.162", "true");
        objectService.EditObjectById(loginProject, passwordProject, objectId, objectData1);
        String objectAlias = "ProjectDocument";
        Map<String, String> objectData3 = new HashMap<>();
        objectData3.put("ProjectRequest", objectId);
        objectData3.put("Type", "879022");
        objectService.CreateWithObjectAlias(loginProject, passwordProject, objectAlias, objectData3);
        userTask.CompleteTask(loginProject, passwordProject, taskId1, true);
        String taskId2 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId2, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, taskId2, true);
        String taskId3 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId, 3);
        assertThat(taskId3, is(notNullValue()));



        objectService.EditObjectById(loginProject, passwordProject, objectId, objectData1);
        String objectAlias1 = "Project";
        Map<String, String> objectData4 = new HashMap<>();
        objectData4.put("ProjectRequest", objectId);
        objectData4.put("Code", codeProject);
        objectData4.put("Name", nameProject);
        objectData4.put("Director", "account.5801");
        objectData4.put("PlannedStartDate", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysAgo));
        objectData4.put("PlannedEndDate", dateAndTimeUtils.LocalDateAndTimeFormatter(thirtyDaysPlus));
        objectData4.put("Isp_ED", "true");
        objectData4.put("Status", "22");
        objectService.CreateWithObjectAlias(loginProject, passwordProject, objectAlias1, objectData4);
        userTask.CompleteTask(loginProject, passwordProject, taskId3, true);

        String processId2 = processObject.GetActiveSubprocessesTimer(loginProject, passwordProject, processId, 5);
        assertThat(processId2, is(notNullValue()));
        String taskId4 = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, processId2, 3);
        assertThat(taskId4, is(notNullValue()));
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(taskId4);
        turnProject.CompleteTask()
                        .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, objectId);
    }
}
