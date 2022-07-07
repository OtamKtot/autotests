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
import ru.comindware.tests.PPM.data.RequestProjectData;

import java.util.Map;

import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.is;
import static org.hamcrest.Matchers.notNullValue;
import static ru.comindware.utils.RandomUtils.getRandomInt;
import static ru.comindware.utils.RandomUtils.getRandomString;


@Owner("Aantipov")
@Severity(SeverityLevel.BLOCKER)
@Feature("Сценарий ППМ")
@Story("Сценарий ППМ")
public class ScenarioTests extends BaseTest {
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
    RequestProjectData requestProjectData = new RequestProjectData();
    AppointDirector appointDirector = new AppointDirector();
    CredentialsConfig config = ConfigFactory.create(CredentialsConfig.class, System.getProperties());
    String loginProject = config.loginProject(),
            passwordProject = config.passwordProject(),
            loginDirector = config.loginDirector(),
            passwordDirector = config.passwordDirector(),
            fioDirector = config.fioDirector(),
            loginRukovoditel = config.loginRukovoditel(),
            passwordRukovoditel = config.passwordRukovoditel(),
            fioRukovoditel = config.fioRukovoditel(),
            nameProject = getRandomString(10),
            codeProject = String.valueOf(getRandomInt(0, 999999)),
            processAppId = "pa.1",
            projectDocumentAlias = "ProjectDocument",
            projectAlias = "Project";
    Map<String, String> requestOnProjectData = requestProjectData.setObjectData(loginProject, passwordProject, nameProject, loginProject),
            rateUrgencyData = requestProjectData.setRateUrgencyData();

    @Test
    @Tag("PPM")
    @DisplayName("Создать заявку на проект")
    void createTicket() {
        loginPage.login(loginProject, passwordProject);
        myTasks.CreateTicketOnProject()
                .WriteDescriptionAndCreate(nameProject)
                .OperationComplete();
    }

    @Test
    @Tag("PPM")
    @DisplayName("Выполнить задачу 'Оформить и утвердить технические требования к ИТ-проекту'")
    void completeTechnicalRequirements() {

        String executeRequestProjectId = processObject.CreateWithData(loginProject, passwordProject, processAppId, null, requestOnProjectData, 0);
        String technicalRequirementsTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(technicalRequirementsTaskId, is(notNullValue()));
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(technicalRequirementsTaskId);
        technicalRequirements.WriteDescription(nameProject)
                .AddNewRecordToCollection()
                .FillFieldOnPopup()
                .CompleteTask()
                .OperationComplete();
        String requestProjectId = userTask.GetBusinessObject(loginProject, passwordProject, technicalRequirementsTaskId);
        objectService.DeleteObjectById(loginProject, passwordProject, requestProjectId);
    }

    @Test
    @Tag("PPM")
    @DisplayName("Выполнить задачу 'Оценить срочность выполнения заявки'")
    void completeRateUrgency() {

        String executeRequestProjectId = processObject.CreateWithData(loginProject, passwordProject, processAppId, null, requestOnProjectData, 0);
        String technicalRequirementsTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(technicalRequirementsTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, technicalRequirementsTaskId, true);
        String rateUrgencyTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(rateUrgencyTaskId);
        rateUrgency.CompleteTask()
                .OperationComplete();
        String requestProjectId = userTask.GetBusinessObject(loginProject, passwordProject, rateUrgencyTaskId);
        objectService.DeleteObjectById(loginProject, passwordProject, requestProjectId);
    }

    @Test
    @Tag("PPM")
    @DisplayName("Выполнить задачу 'Организовать предпроектную оценку'")
    void completeOrganizeEvaluation() {

        String executeRequestProjectId = processObject.CreateWithData(loginProject, passwordProject, processAppId, null, requestOnProjectData, 0);
        String technicalRequirementsTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(technicalRequirementsTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, technicalRequirementsTaskId, true);
        String rateUrgencyTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        String requestProjectId = userTask.GetBusinessObject(loginProject, passwordProject, rateUrgencyTaskId);
        objectService.EditObjectById(loginProject, passwordProject, requestProjectId, rateUrgencyData);
        userTask.CompleteTask(loginProject, passwordProject, rateUrgencyTaskId, true);
        String organizeEvaluationTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(organizeEvaluationTaskId);
        organizeEvaluation.CompleteTask()
                .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, requestProjectId);
    }


    @Test
    @Tag("PPM")
    @DisplayName("Выполнить задачу 'Формирование проектов по заявке'")
    void completeEstablishProject() {

        String executeRequestProjectId = processObject.CreateWithData(loginProject, passwordProject, processAppId, null, requestOnProjectData, 0);
        String technicalRequirementsTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(technicalRequirementsTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, technicalRequirementsTaskId, true);
        String rateUrgencyTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(rateUrgencyTaskId, is(notNullValue()));
        String requestProjectId = userTask.GetBusinessObject(loginProject, passwordProject, rateUrgencyTaskId);
        objectService.EditObjectById(loginProject, passwordProject, requestProjectId, rateUrgencyData);
        Map<String, String> rateUrgencyData = requestProjectData.setProjectData(requestProjectId);
        objectService.CreateWithObjectAlias(loginProject, passwordProject, projectDocumentAlias, rateUrgencyData);
        userTask.CompleteTask(loginProject, passwordProject, rateUrgencyTaskId, true);
        String organizeEvaluationTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(organizeEvaluationTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, organizeEvaluationTaskId, true);
        String establishProjectTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(establishProjectTaskId, is(notNullValue()));
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(establishProjectTaskId);
        establishProject.FillFormField(nameProject, codeProject, fioDirector)
                .CompleteTask()
                .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, requestProjectId);
    }


    @Test
    @Tag("PPM")
    @DisplayName("Выполнить задачу 'Включение проекта в план график'")
    void completeTurnProject() {

        String executeRequestProjectId = processObject.CreateWithData(loginProject, passwordProject, processAppId, null, requestOnProjectData, 0);
        String technicalRequirementsTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(technicalRequirementsTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, technicalRequirementsTaskId, true);
        String rateUrgencyTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(rateUrgencyTaskId, is(notNullValue()));
        String requestProjectId = userTask.GetBusinessObject(loginProject, passwordProject, rateUrgencyTaskId);
        objectService.EditObjectById(loginProject, passwordProject, requestProjectId, rateUrgencyData);
        Map<String, String> rateUrgencyData = requestProjectData.setProjectData(requestProjectId);
        objectService.CreateWithObjectAlias(loginProject, passwordProject, projectDocumentAlias, rateUrgencyData);
        userTask.CompleteTask(loginProject, passwordProject, rateUrgencyTaskId, true);
        String organizeEvaluationTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(organizeEvaluationTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, organizeEvaluationTaskId, true);
        String establishProjectTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(establishProjectTaskId, is(notNullValue()));
        objectService.EditObjectById(loginProject, passwordProject, requestProjectId, rateUrgencyData);
        Map<String, String> establishProjectData = requestProjectData.setEstablishProjectData(loginProject, passwordProject, nameProject, codeProject, loginDirector, requestProjectId);
        objectService.CreateWithObjectAlias(loginProject, passwordProject, projectAlias, establishProjectData);
        userTask.CompleteTask(loginProject, passwordProject, establishProjectTaskId, true);
        String turnProjectProcessId = processObject.GetActiveSubprocessesTimer(loginProject, passwordProject, executeRequestProjectId, 5);
        assertThat(turnProjectProcessId, is(notNullValue()));
        String turnProjectTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, turnProjectProcessId, 3);
        assertThat(turnProjectTaskId, is(notNullValue()));
        loginPage.login(loginProject, passwordProject);
        myTasks.OpenTask(turnProjectTaskId);
        turnProject.CompleteTask()
                .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, requestProjectId);
    }


    @Test
    @Tag("PPM")
    @DisplayName("Выполнить задачу 'Назначение руководителя проекта'")
    void completeAppointDirector() {

        String executeRequestProjectId = processObject.CreateWithData(loginProject, passwordProject, processAppId, null, requestOnProjectData, 0);
        String technicalRequirementsTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(technicalRequirementsTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, technicalRequirementsTaskId, true);
        String rateUrgencyTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(rateUrgencyTaskId, is(notNullValue()));
        String requestProjectId = userTask.GetBusinessObject(loginProject, passwordProject, rateUrgencyTaskId);
        objectService.EditObjectById(loginProject, passwordProject, requestProjectId, rateUrgencyData);
        Map<String, String> rateUrgencyData = requestProjectData.setProjectData(requestProjectId);
        objectService.CreateWithObjectAlias(loginProject, passwordProject, projectDocumentAlias, rateUrgencyData);
        userTask.CompleteTask(loginProject, passwordProject, rateUrgencyTaskId, true);
        String organizeEvaluationTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(organizeEvaluationTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, organizeEvaluationTaskId, true);
        String establishProjectTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeRequestProjectId, 3);
        assertThat(establishProjectTaskId, is(notNullValue()));
        objectService.EditObjectById(loginProject, passwordProject, requestProjectId, rateUrgencyData);
        Map<String, String> establishProjectData = requestProjectData.setEstablishProjectData(loginProject, passwordProject, nameProject, codeProject, loginDirector, requestProjectId);
        objectService.CreateWithObjectAlias(loginProject, passwordProject, projectAlias, establishProjectData);
        userTask.CompleteTask(loginProject, passwordProject, establishProjectTaskId, true);
        String turnProjectProcessId = processObject.GetActiveSubprocessesTimer(loginProject, passwordProject, executeRequestProjectId, 5);
        assertThat(turnProjectProcessId, is(notNullValue()));
        String turnProjectTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, turnProjectProcessId, 3);
        assertThat(turnProjectTaskId, is(notNullValue()));
        userTask.CompleteTask(loginProject, passwordProject, turnProjectTaskId, true);
        String executeProjectProcessId = processObject.GetActiveSubprocessesTimer(loginProject, passwordProject, turnProjectProcessId, 5);
        assertThat(turnProjectProcessId, is(notNullValue()));
        String appointDirectorTaskId = processObject.GetActiveSubtasksTimer(loginProject, passwordProject, executeProjectProcessId, 3);
        assertThat(turnProjectTaskId, is(notNullValue()));
        loginPage.login(loginDirector, passwordDirector);
        myTasks.OpenTask(appointDirectorTaskId);
        appointDirector.FillFormField(fioRukovoditel)
                .CompleteTask()
                .OperationComplete();
        objectService.DeleteObjectById(loginProject, passwordProject, requestProjectId);
    }
}
