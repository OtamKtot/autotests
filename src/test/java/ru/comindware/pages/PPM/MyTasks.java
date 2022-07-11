package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Condition.visible;
import static com.codeborne.selenide.Selenide.*;

public class MyTasks {

    SelenideElement createTicket = $("[title=\"Создать заявку на проект\"]"),
            textField = $(".input.input_text"),
            dropDown = $x("//*[@class='js-input bubbles__input']"),
            dropDown2 = $x("(//*[@class='js-input bubbles__input'])[2]"),
            firstElementFromDropdown = $(".dd-list__i.selected"),
            dateTimeField = $x("//*[@class='editor editor_date-time js-dropdown__root ShortDate editor_empty required']"),
            oldDateTime = $(".day.old"),
            newDateTime = $(".day.new", 2),
            createTicket2 = $x("(//*[text() = 'Создать заявку на проект'])[2]"),
            notificationContainer = $(".notification-body_container"),
            popup = $(".layout__popup-view-content"),
            myTasks = $("[title=\"Мои задачи\"]"),
            refresh = $("[title=\"Обновить список\"]"),
            technicalRequirement = $("[title=\"Оформить и утвердить технические требования к ИТ-проекту\"]"),
            loader = $(".loader"),
            logo = $(".composite-user-abr__container"),
            logOut = $(".js-logout"),
            rateUrgency = $("[title=\"Оценить срочность выполнения заявки\"]"),
            organizeEvaluation = $("[title=\"Организовать предпроектную оценку\"]"),
            establishProject = $("[title=\"Формирование проектов по заявке\"]"),
            turnProject = $("[title=\"Включение проекта в план-график\"]");

    @Step("На боковой навигации выбрать \"Создать заявку на проект\"")
    public MyTasks CreateTicketOnProject() {
        createTicket.click();
        return this;
    }

    @Step("Заполнить обязательные поля и нажать \"Создать заявку на проект\"")
    public MyTasks WriteDescriptionAndCreate(String nameProject) {
        popup.should(visible);
        textField.setValue(nameProject);
        dropDown.click();
        firstElementFromDropdown.click();
        dropDown2.click();
        firstElementFromDropdown.click();
        dateTimeField.click();
        oldDateTime.click();
        dateTimeField.click();
        newDateTime.click();
        createTicket2.click();
        return this;
    }

    @Step("Заявка создана")
    public MyTasks OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        loader.shouldNotBe(visible);
        return this;
    }

    @Step("Перейти в Мои Задачи")
    public MyTasks GoToMyTasks() {
        loader.shouldNotBe(visible);
        myTasks.click();
        return this;
    }

    @Step("Обновить список")
    public MyTasks RefreshList() {
        refresh.click();
        return this;
    }

    @Step("Выйти из системы")
    public MyTasks LogOut() {
        logo.click();
        logOut.click();
        return this;
    }

    @Step("Открыть задачу 'Оформить и утвердить технические требования к ИТ-проекту' ")
    public MyTasks OpenTechnicalRequirements() {
        technicalRequirement.click();
        technicalRequirement.doubleClick();
        return this;
    }

    @Step("Открыть задачу 'Оценить срочность выполнения заявки' ")
    public MyTasks OpenRateUrgency() {
        rateUrgency.click();
        rateUrgency.doubleClick();
        return this;
    }

    @Step("Открыть задачу 'Организовать предпроектную оценку' ")
    public MyTasks OpenOrganizeEvaluation() {
        organizeEvaluation.click();
        organizeEvaluation.doubleClick();
        return this;
    }

    @Step("Открыть задачу 'Формирование проектов по заявке' ")
    public MyTasks OpenEstablishProject() {
        establishProject.click();
        establishProject.doubleClick();
        return this;
    }

    @Step("Открыть задачу 'Включение проекта в план-график' ")
    public MyTasks OpenTurnProject() {
        turnProject.click();
        turnProject.doubleClick();
        return this;
    }

    @Step("Открыть задачу 'Назначение руководителя проекта' ")
    public MyTasks OpenAppointDirector(String nameProject, String codeProject) {
        $("[title=\"Назначение руководителя проекта" + " (" + codeProject + " - " + nameProject + ")" + "\"]").click();
        $("[title=\"Назначение руководителя проекта" + " (" + codeProject + " - " + nameProject + ")" + "\"]").doubleClick();
        return this;
    }

    @Step("Открыть задачу по id ")
    public MyTasks OpenTask(String id) {
        open("#/Resolver/" + id);
        return this;
    }
}
