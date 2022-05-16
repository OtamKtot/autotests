package ru.antipant.tests;

import com.codeborne.selenide.logevents.SelenideLogger;
import io.qameta.allure.*;
import io.qameta.allure.selenide.AllureSelenide;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;
import ru.antipant.pages.BaseTest;

import static com.codeborne.selenide.Selectors.withText;
import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.open;
import static org.openqa.selenium.By.linkText;
import static org.openqa.selenium.By.partialLinkText;

@Owner("Antipant")
@Severity(SeverityLevel.CRITICAL)
@Feature("Задачи в репозитории")
@Story("Просмотр созданных задач в репозитории")
public class SelenideTest extends BaseTest {

    @Test
    @DisplayName("Хороший тест")
    public void testGithubIssue() {
        SelenideLogger.addListener("allure", new AllureSelenide());

        open("https://github.com");

        $(".header-search-input").click();
        $(".header-search-input").sendKeys("Antipant/FirstLabJavaQAguru");
        $(".header-search-input").submit();

        $(linkText("Antipant/FirstLabJavaQAguru")).click();
        $(partialLinkText("Issues")).click();
        $(withText("#2")).click();
    }

}