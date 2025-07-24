--------------- SQL ---------------

CREATE TABLE public."StudentGrades" (
  "Id" SERIAL NOT NULL,
  "StudentId" INTEGER NOT NULL,
  "Subject" TEXT NOT NULL,
  "Grade" NUMERIC(4,2) NOT NULL,
  PRIMARY KEY("Id")
) ;

--------------- SQL ---------------

ALTER TABLE public."StudentGrades"
  ADD CONSTRAINT "StudentGrades_fk" FOREIGN KEY ("StudentId")
    REFERENCES public."Students"("Id")
    ON DELETE CASCADE
    ON UPDATE NO ACTION
    NOT DEFERRABLE;
