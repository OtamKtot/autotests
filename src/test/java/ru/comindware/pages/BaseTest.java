package ru.comindware.pages;

import com.codeborne.selenide.Configuration;
import com.codeborne.selenide.logevents.SelenideLogger;
import io.qameta.allure.selenide.AllureSelenide;
import org.aeonbits.owner.ConfigFactory;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeAll;
import org.openqa.selenium.remote.DesiredCapabilities;
import ru.comindware.config.CredentialsConfig;
import ru.comindware.helpers.Attach;

import static com.codeborne.selenide.Selenide.closeWebDriver;

public class BaseTest {

    @BeforeAll
    static void setUp() {
        SelenideLogger.addListener("AllureSelenide", new AllureSelenide());

        CredentialsConfig config = ConfigFactory.create(CredentialsConfig.class);

        String propertyBrowser = System.getProperty("propertyBrowser", "chrome");
        String propertyVersion = System.getProperty("propertyVersion", "22.1");

        String propertyMainPageUrl = System.getProperty("propertyMainPageUrl", "https://ppm.36.qa.comindware.net/");
        String propertyBrowserSize = System.getProperty("propertyBrowserSize", "1980x1080");
        String propertyRemoteUrl = System.getProperty("propertySelenoidUrl", "192.168.0.65:4444/wd/hub");

        Configuration.browser = propertyBrowser;
        Configuration.browserVersion = propertyVersion;
        Configuration.baseUrl = propertyMainPageUrl;
        Configuration.browserSize = propertyBrowserSize;
        Configuration.remote = "http://" + propertyRemoteUrl;
        Configuration.timeout = 60000;


        DesiredCapabilities capabilities = new DesiredCapabilities();
        capabilities.setCapability("enableVNC", true);
        capabilities.setCapability("enableVideo", true);
        Configuration.browserCapabilities = capabilities;
    }

    @AfterEach
    void addAttachments() {
        Attach.screenshotAs("Last screenshot");
        Attach.pageSource();
        Attach.browserConsoleLogs();
        Attach.addVideo();
        closeWebDriver();
    }

}