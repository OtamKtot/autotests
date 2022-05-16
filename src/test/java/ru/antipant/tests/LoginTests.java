package ru.antipant.tests;

import org.aeonbits.owner.ConfigFactory;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import ru.antipant.config.CredentialsConfig;
import ru.antipant.pages.BaseTest;
import ru.antipant.pages.LoginPage;

import static com.codeborne.selenide.Selenide.sleep;

public class LoginTests extends BaseTest {
    LoginPage loginPage = new LoginPage();
    CredentialsConfig config = ConfigFactory.create(CredentialsConfig.class);
    String login = config.login();
    String password = config.password();

    @Test
    @DisplayName("Хороший тест")
    void setLoginPage() {
        loginPage.login(login,password);
        sleep(10000);

    }
}
