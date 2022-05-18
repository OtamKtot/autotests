package ru.antipant.tests;

import io.qameta.allure.*;
import org.aeonbits.owner.ConfigFactory;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import ru.antipant.config.CredentialsConfig;
import ru.antipant.pages.BaseTest;
import ru.antipant.pages.LoginPage;


@Owner("Aantipov")
@Severity(SeverityLevel.BLOCKER)
@Feature("Страница логина")
@Story("Страница логина и регистрации")
public class LoginTests extends BaseTest {
    LoginPage loginPage = new LoginPage();
    CredentialsConfig config = ConfigFactory.create(CredentialsConfig.class);
    String login = config.login();
    String password = config.password();

    @Test
    @DisplayName("Залогиниться в платформу")
    void setLoginPage() {
        loginPage.login(login,password);
    }
}
