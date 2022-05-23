package ru.comindware.tests.PPM;

import io.qameta.allure.*;
import org.aeonbits.owner.ConfigFactory;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Tag;
import org.junit.jupiter.api.Test;
import ru.comindware.config.CredentialsConfig;
import ru.comindware.pages.BaseTest;
import ru.comindware.pages.LoginPage;
import ru.comindware.pages.PPM.MyTasks;


@Owner("Aantipov")
@Severity(SeverityLevel.BLOCKER)
@Feature("Сценарий ППМ")
@Story("Сценарий ППМ")
public class MyTasksTests extends BaseTest {
    LoginPage loginPage = new LoginPage();
    MyTasks myTasks = new MyTasks();
    CredentialsConfig config = ConfigFactory.create(CredentialsConfig.class);
    String login = config.login();
    String password = config.password();

    @Test
    @DisplayName("Создать заявку на проект")
    @Tag("PPM")
    void createTicket() {
        loginPage.login(login, password);
        myTasks.CreateTicketOnProject()
                .WriteDescriptionAndCreate()
                .OperationComplete();
    }
}
