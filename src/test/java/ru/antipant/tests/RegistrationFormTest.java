package ru.antipant.tests;

import org.junit.jupiter.api.*;
import ru.antipant.pages.BaseTest;
import ru.antipant.pages.RegistrationFormPage;

import static java.lang.String.format;
import static ru.antipant.utils.FakerUtils.*;

public class RegistrationFormTest extends BaseTest {

    RegistrationFormPage registrationFormPage = new RegistrationFormPage();
    String firstName = getFakerName(),
            lastName = getFakerSurName(),
            userEmail = getFakerEmail(),
            userGender = "Other",
            userNumber = "1231231230",
            day = "30",
            month = "July",
            year = "2008",
            subjects = "Math",
            hobbies = "Sports",
            namePicture = "Pushkin.jpg",
            address = getFakerAddress(),
            state = "NCR",
            city = "Delhi";
    String expectedFullName = format("%s %s", firstName, lastName),
            expectedDate = format("%s %s,%s", day, month, year),
            expectedStateAndCity = format("%s %s", state, city);

    @Test
    public void registrationFormTest() {
        registrationFormPage
                .openPage()
                .setFirstName(firstName)
                .setLastName(lastName)
                .setUserEmail(userEmail)
                .setGender(userGender)
                .setUserNumber(userNumber)
                .setBirthDate(day, month, year)
                .setSubjects(subjects)
                .setUserHobbies(hobbies)
                .upLoadPicture(namePicture)
                .setAddress(address)
                .setState(state)
                .setCity(city)
                .submitClick()
                .checkCompletedForm("Student Name", expectedFullName)
                .checkCompletedForm("Student Email", userEmail)
                .checkCompletedForm("Gender", userGender)
                .checkCompletedForm("Mobile", userNumber)
                .checkCompletedForm("Date of Birth", expectedDate)
                .checkCompletedForm("Subjects", subjects)
                .checkCompletedForm("Hobbies", hobbies)
                .checkCompletedForm("Picture", namePicture)
                .checkCompletedForm("Address", address)
                .checkCompletedForm("State and City", expectedStateAndCity);
    }

}